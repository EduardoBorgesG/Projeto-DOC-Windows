# Projeto-DOC-Windows
Projeto DOC-Windows
Para criar o banco de dados na qual foi usado nesse código efetue o seguinte script:

    CREATE TABLE IF NOT EXISTS nascimento (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_registrado VARCHAR(80),
    data_nascimento_registrado DATE,
    nome_mae VARCHAR(80),
    data_nascimento_mae DATE,
    cpf_mae VARCHAR(50),
    nome_pai VARCHAR(80),
    data_nascimento_pai DATE,
    cpf_pai VARCHAR(50),
    data_nascimento_pai DATE);
    
    CREATE TABLE IF NOT EXISTS casamento(
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome_c1 VARCHAR(80),
    data_nascimento_c1 DATE,
    cpf_c1 VARCHAR(30),
    nome_c1_mae VARCHAR(80),
    data_nascimento_c1_mae DATE,
    cpf_c1_mae VARCHAR(30),
    nome_c1_pai VARCHAR(80),
    data_nascimento_c1_pai VARCHAR(80),
    cpf_c1_pai VARCHAR(30),
    nome_c2 VARCHAR(80),
    data_nascimento_c2 DATE,
    cpf_c2 VARCHAR(30),
    nome_c2_mae VARCHAR(80),
    data_nascimento_c2_mae DATE,
    cpf_c2_mae VARCHAR(30),
    nome_c2_pai VARCHAR(80),
    data_nascimento_c2_pai VARCHAR(80),
    cpf_c2_pai VARCHAR(30),
    data_registro DATE,
    data_casamento DATE);
    
    CREATE TABLE IF NOT EXISTS obito2(
        id INT AUTO_INCREMENT PRIMARY KEY,
        nome_falecido VARCHAR(80),
        data_nascimento_f DATE,
        nome_mae VARCHAR(80),
        data_nascimento_mae DATE,
        nome_pai VARCHAR(80),
        data_nascimento_pai DATE,
        data_registro DATE,
        data_obito DATE);
