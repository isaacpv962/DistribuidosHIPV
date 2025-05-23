// Importaciones
const express = require('express');
const { ApolloServer, gql } = require('apollo-server-express');
const mysql = require('mysql2/promise');

// Configuración de la base de datos
const dbConfig = {
  host: 'localhost',
  user: 'root',
  password: '1234',
  database: 'segip_graphql_db',
  charset: 'utf8mb4'
};

// Definición del esquema GraphQL
const typeDefs = gql`
  type Deuda {
    id: Int!
    concepto: String!
    monto: Float!
  }

  type Persona {
    CI: String!
    nombres: String!
    primerApellido: String!
    segundoApellido: String!
    deudas: [Deuda!]!         
  }

  type Query {
    persona(ci: String!): Persona
  }
`;

// Resolvers
const resolvers = {
  Query: {
    persona: async (_, { ci }) => {
      const conn = await mysql.createConnection(dbConfig);

      // 1. Obtengo la persona
      const [personRows] = await conn.execute(
        'SELECT CI, nombres, primerApellido, segundoApellido FROM persona WHERE CI = ?',
        [ci]
      );
      if (personRows.length === 0) {
        await conn.end();
        return null;
      }
      const persona = personRows[0];

      // 2. Obtengo las deudas de esa persona
      const [deudaRows] = await conn.execute(
        'SELECT id, concepto, monto FROM deuda WHERE ci = ?',
        [ci]
      );
      await conn.end();

      return {
        CI: persona.CI,
        nombres: persona.nombres,
        primerApellido: persona.primerApellido,
        segundoApellido: persona.segundoApellido,
        deudas: deudaRows.map(d => ({
          id: d.id,
          concepto: d.concepto,
          monto: d.monto
        }))
      };
    }
  }
};


async function startServer() {
  // Crear app Express
  const app = express();

  // Instanciar ApolloServer
  const server = new ApolloServer({ typeDefs, resolvers });
  await server.start();
  server.applyMiddleware({ app, path: '/graphql' });

  // Iniciar servidor
  const PORT = 4000;
  app.listen(PORT, () => {
    console.log(`🚀 SEGIP GraphQL escuchando en http://localhost:${PORT}/graphql`);
  });
}

// Arrancar
startServer().catch(err => {
  console.error('Error al iniciar SEGIP GraphQL:', err);
});
