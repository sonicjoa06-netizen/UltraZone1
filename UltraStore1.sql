CREATE DATABASE IF NOT EXISTS UltraZone;
USE UltraZone;

-- 2. Cria a tabela de Produtos
-- Usamos DECIMAL para preços, pois float/double perdem precisão em cálculos financeiros.
CREATE TABLE IF NOT EXISTS Produtos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Preco DECIMAL(10, 2) NOT NULL,
    Categoria VARCHAR(50) DEFAULT 'Geral',
    DataCadastro DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE IF NOT EXISTS Usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    Senha VARCHAR(50),
    Nivel VARCHAR(20)
);

-- 3. Insere alguns dados de exemplo
INSERT INTO Produtos (Nome, Preco, Categoria) VALUES 
('STARFIELD', 250.00, 'RPG'),
('Gears Of War 4', 99.00, 'TPS'),
('Forza Horizon 6', 300.00, 'RACING'),
('Call Of Duty: Black Ops 7', 320.00, 'FPS');


INSERT INTO Usuarios (Nome, Email, Senha, Nivel) 
VALUES ('Administrador', 'admin@loja.com', '123456', 'Admin');

INSERT INTO Usuarios (Nome, Email, Senha, Nivel) 
VALUES ('Funcionario Novo', 'usuario@loja.com', '123456', 'Operador');


select * from Produtos;