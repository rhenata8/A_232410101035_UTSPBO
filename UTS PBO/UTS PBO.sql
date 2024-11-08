CREATE TABLE BUKU_BARU (
	id SERIAL PRIMARY KEY,
	judul VARCHAR(256) NOT NULL,
	Pengarang VARCHAR(100) NOT NULL,
	Tahun_Terbit INT NOT NULL,
	Kategori VARCHAR(100) NOT NULL
);

INSERT INTO BUKU_BARU (judul, pengarang, tahun_terbit, kategori) VALUES
('manusia', 'Nana', 2023, 'fiksi'),
('bumi', 'Gita', 2022, 'Non fiksi');

select * from BUKU_BARU

CREATE TABLE users (
	id SERIAL PRIMARY KEY,username VARCHAR(50) UNIQUE NOT NULL,
	password VARCHAR(256) NOT NULL,
	nama VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL
);

select * from users

INSERT INTO users (nama, password, email,username) VALUES
('Rhe', '123', 'rhena@gmail.com','aku1'),
('Nana', '111', 'rhenata@gmail.com','aku2');