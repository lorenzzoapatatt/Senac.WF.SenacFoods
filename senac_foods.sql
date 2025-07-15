-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Maio-2025 às 02:45
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `senac_foods`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cardapio_item`
--

CREATE TABLE `cardapio_item` (
  `ID` int(11) NOT NULL,
  `TITULO` varchar(200) NOT NULL,
  `DESCRICAO` text NOT NULL,
  `PRECO` decimal(10,2) NOT NULL,
  `POSSUI_PREPARO` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cardapio_item`
--

INSERT INTO `cardapio_item` (`ID`, `TITULO`, `DESCRICAO`, `PRECO`, `POSSUI_PREPARO`) VALUES
(1, 'XIS', 'BIFE 180G\r\nALFACE\r\nTOMATE\r\nQUEIJO\r\nMAIONESE', '25.00', 1),
(2, 'COCA COLA ORIGINAL 350ML', '', '5.50', 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `comanda`
--

CREATE TABLE `comanda` (
  `ID` int(11) NOT NULL,
  `NUMERO_MESA` int(11) NOT NULL,
  `NOME_CLIENTE` varchar(150) NOT NULL,
  `SITUACAO_COMANDA` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `comanda`
--

INSERT INTO `comanda` (`ID`, `NUMERO_MESA`, `NOME_CLIENTE`, `SITUACAO_COMANDA`) VALUES
(1, 100, 'JOÃO RODRIGUES', 1),
(2, 101, 'NATASHA SUAREZ', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `comanda_item`
--

CREATE TABLE `comanda_item` (
  `ID` int(11) NOT NULL,
  `CARDAPIO_ITEM_ID` int(11) NOT NULL,
  `COMANDA_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `comanda_item`
--

INSERT INTO `comanda_item` (`ID`, `CARDAPIO_ITEM_ID`, `COMANDA_ID`) VALUES
(1, 1, 1),
(2, 2, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `mesa`
--

CREATE TABLE `mesa` (
  `ID` int(11) NOT NULL,
  `NUMERO_MESA` int(11) NOT NULL,
  `SITUACAO_MESA` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `mesa`
--

INSERT INTO `mesa` (`ID`, `NUMERO_MESA`, `SITUACAO_MESA`) VALUES
(1, 100, 1),
(2, 101, 1),
(3, 102, 0),
(4, 103, 0),
(5, 104, 0),
(6, 105, 0);

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido_cozinha`
--

CREATE TABLE `pedido_cozinha` (
  `ID` int(11) NOT NULL,
  `COMANDA_ID` int(11) NOT NULL,
  `SITUACAO_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido_cozinha_item`
--

CREATE TABLE `pedido_cozinha_item` (
  `ID` int(11) NOT NULL,
  `PEDIDO_COZINHA_ID` int(11) NOT NULL,
  `COMANDA_ITEM_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(100) NOT NULL,
  `EMAIL` varchar(100) NOT NULL,
  `SENHA` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cardapio_item`
--
ALTER TABLE `cardapio_item`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `comanda`
--
ALTER TABLE `comanda`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `comanda_item`
--
ALTER TABLE `comanda_item`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `mesa`
--
ALTER TABLE `mesa`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `pedido_cozinha`
--
ALTER TABLE `pedido_cozinha`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `pedido_cozinha_item`
--
ALTER TABLE `pedido_cozinha_item`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cardapio_item`
--
ALTER TABLE `cardapio_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `comanda`
--
ALTER TABLE `comanda`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `comanda_item`
--
ALTER TABLE `comanda_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `mesa`
--
ALTER TABLE `mesa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `pedido_cozinha`
--
ALTER TABLE `pedido_cozinha`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pedido_cozinha_item`
--
ALTER TABLE `pedido_cozinha_item`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
