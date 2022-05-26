USE AlimentaraBD


INSERT INTO Departament
	VALUES('Produse lactate'),
		  ('Carne'),
		  ('Mezeluri'),
		  ('Peste'),
		  ('Aperitive'),
		  ('Produse Panificatie'),
		  ('Produse de cofetarie'),
		  ('Conserve'),
		  ('Produse congelate'),
		  ('Ceai, cafea'),
		  ('Dulciuri'),
		  ('Snack-uri'),
		  ('Bauturi nealcoolice'),
		  ('Bauturi alcoolice'),
		  ('Băcănie');


INSERT INTO Localitate
	VALUES('Chisinau'),
			('Orhei'),
			('Edinet'),
			('Balti'),
			('Soroca'),
			('Calarasi'),
			('Durlesti'),
			('Cricova'),
			('Criuleni'),
			('Ungheni'),
			('Drochia'),
			('Cahul'),
			('Cimislia'),
			('Comrat'),
			('Floresti'),
			('Falesti'),
			('Glodeni'),
			('Causeni');


INSERT INTO Producator
	VALUES('MILKMARK', 'Str. Cuza Voda 1', '+373 (06) 100 503', 1),
('GIFIS', 'Str. Stefan cel Mare 2', '+373 (06) 101 505', 2),
('VEGA MILK', 'Str. Tolstoi 3', '+373 (06) 102 507', 3),
('JLC', 'Str. Traian 4', '+373 (06) 103 509', 4),
('ZUZU', 'Str. Sarmizecetusa 5', '+373 (06) 104 511', 5),
('PORUMBACA', 'Str. Gradina Botanica 6', '+373 (06) 105 513', 6),
('CARMEZ', 'Str. Puskin 7', '+373 (06) 106 515', 7),
('FILLETTI', 'Str. Alba-Iulia 8', '+373 (06) 107 517', 8),
('VERONNI', 'Str. Muncesti 9', '+373 (06) 108 519', 9),
('PEGAS', 'Str. Independentii 10', '+373 (06) 109 521', 10),
('GURMAN', 'Str. Hristo-Botev 11', '+373 (06) 110 523', 11),
('ERMES FONTANA', 'Str. Grigore Vieru 12', '+373 (06) 111 525', 12),
('NATUR AGRO', 'Str. Albisoara 13', '+373 (06) 112 527', 13),
('BLUE SHARK', 'Str. Dacia 14', '+373 (06) 113 529', 14),
('OCEAN FISH', 'Str. Decebal 15', '+373 (06) 114 531', 15),
('SLAVENA', 'Str. Burebista 16', '+373 (06) 115 533', 16),
('MATIAS', 'Str. Padurii 17', '+373 (06) 116 535', 17),
('NATURFISH', 'Str. Columna 18', '+373 (06) 117 537', 18),
('ARIS', 'Str. Basarabeasca 19', '+373 (06) 118 539', 1),
('GUTAROM', 'Str. Orheiului 20', '+373 (06) 119 541', 2),
('PANINELLA', 'Str. Petru Rares 21', '+373 (06) 120 543', 3),
('SANTA BREMOR', 'Str. Cuza Voda 22', '+373 (06) 121 545', 4),
('DELICIO', 'Str. Stefan cel Mare 23', '+373 (06) 122 547', 5),
('BELMAR', 'Str. Tolstoi 24', '+373 (06) 123 549', 6),
('HEINZ', 'Str. Traian 25', '+373 (06) 124 551', 7),
('LA LORRAINE', 'Str. Sarmizecetusa 26', '+373 (06) 125 553', 8),
('PRAVIA', 'Str. Gradina Botanica 27', '+373 (06) 126 555', 9),
('BALTIA', 'Str. Puskin 28', '+373 (06) 127 557', 10),
('FRANZELUTA', 'Str. Alba-Iulia 29', '+373 (06) 128 559', 11),
('7 SPICE', 'Str. Muncesti 30', '+373 (06) 129 561', 12),
('HAIDUC', 'Str. Independentii 31', '+373 (06) 130 563', 13),
('RISO SCOTTI', 'Str. Hristo-Botev 32', '+373 (06) 131 565', 14),
('JEDEN TAG', 'Str. Grigore Vieru 33', '+373 (06) 132 567', 15),
('STOKSON', 'Str. Albisoara 34', '+373 (06) 133 569', 16),
('MON AMI', 'Str. Dacia 35', '+373 (06) 134 571', 17),
('COLIBRI', 'Str. Decebal 36', '+373 (06) 135 573', 18),
('LAN PATE', 'Str. Burebista 37', '+373 (06) 136 575', 1),
('ARDEALUL', 'Str. Padurii 38', '+373 (06) 137 577', 2),
('PAMAPOL', 'Str. Columna 39', '+373 (06) 138 579', 3),
('DIPLOMATS', 'Str. Basarabeasca 40', '+373 (06) 139 581', 4),
('RIO MARE', 'Str. Orheiului 41', '+373 (06) 140 583', 5),
('MAXIMS', 'Str. Petru Rares 42', '+373 (06) 141 585', 6),
('BERNAL', 'Str. Cuza Voda 43', '+373 (06) 142 587', 7),
('LORAS', 'Str. Stefan cel Mare 44', '+373 (06) 143 589', 8),
('TELLI', 'Str. Tolstoi 45', '+373 (06) 144 591', 9),
('BOFMAR', 'Str. Traian 46', '+373 (06) 145 593', 10),
('VITA', 'Str. Sarmizecetusa 1', '+373 (06) 146 595', 11),
('NUTELLA', 'Str. Gradina Botanica 2', '+373 (06) 147 597', 12),
('GOLDEN FISH', 'Str. Puskin 3', '+373 (06) 148 599', 13),
('EDENIA', 'Str. Alba-Iulia 4', '+373 (06) 149 601', 14),
('FANTASY', 'Str. Muncesti 5', '+373 (06) 150 603', 15),
('KARDEL', 'Str. Independentii 6', '+373 (06) 151 605', 16),
('POLTINO', 'Str. Hristo-Botev 7', '+373 (06) 152 607', 17),
('PANADERO', 'Str. Grigore Vieru 8', '+373 (06) 153 609', 18),
('CASA NOASTRA', 'Str. Albisoara 9', '+373 (06) 154 611', 1),
('FRIGO', 'Str. Dacia 10', '+373 (06) 155 613', 2),
('DRANCOR', 'Str. Decebal 11', '+373 (06) 156 615', 3),
('SANDRA', 'Str. Burebista 12', '+373 (06) 157 617', 4),
('PLANTEUR', 'Str. Padurii 13', '+373 (06) 158 619', 5),
('PEPPOS', 'Str. Columna 14', '+373 (06) 159 621', 6),
('RICHARD', 'Str. Basarabeasca 15', '+373 (06) 160 623', 7),
('GREENFIELD', 'Str. Orheiului 16', '+373 (06) 161 625', 8),
('KONTI', 'Str. Petru Rares 17', '+373 (06) 162 627', 9),
('AVK', 'Str. Cuza Voda 18', '+373 (06) 163 629', 10),
('MERCI', 'Str. Stefan cel Mare 19', '+373 (06) 164 631', 11),
('BUCURIA', 'Str. Tolstoi 20', '+373 (06) 165 633', 12),
('KINDER', 'Str. Traian 21', '+373 (06) 166 635', 13),
('ROSHEN', 'Str. Sarmizecetusa 22', '+373 (06) 167 637', 14),
('LAYS', 'Str. Gradina Botanica 23', '+373 (06) 168 639', 15),
('DORITOS', 'Str. Puskin 24', '+373 (06) 169 641', 16),
('TAFFEL', 'Str. Alba-Iulia 25', '+373 (06) 170 643', 17),
('CHIO', 'Str. Muncesti 26', '+373 (06) 171 645', 18),
('SANT ANNA', 'Str. Independentii 27', '+373 (06) 172 647', 1),
('MATTONI', 'Str. Hristo-Botev 28', '+373 (06) 173 649', 2),
('SPRITE', 'Str. Grigore Vieru 29', '+373 (06) 174 651', 3),
('FANTA', 'Str. Albisoara 30', '+373 (06) 175 653', 4),
('COCA COLA', 'Str. Dacia 31', '+373 (06) 176 655', 5),
('LETTO', 'Str. Decebal 32', '+373 (06) 177 657', 6),
('CRICOVA VINTAGE', 'Str. Burebista 33', '+373 (06) 178 659', 7),
('BOIAR', 'Str. Padurii 34', '+373 (06) 179 661', 8),
('APRIORI', 'Str. Columna 35', '+373 (06) 180 663', 9),
('BACIO DI BOLLE', 'Str. Basarabeasca 36', '+373 (06) 181 665', 10),
('CAMARAD', 'Str. Orheiului 37', '+373 (06) 182 667', 11),
('EFES', 'Str. Petru Rares 38', '+373 (06) 183 669', 12),
('MOS ZAHARIA', 'Str. Cuza Voda 39', '+373 (06) 184 671', 13),
('BUNETTO', 'Str. Stefan cel Mare 40', '+373 (06) 185 673', 14),
('BOROMIR', 'Str. Tolstoi 41', '+373 (06) 186 675', 15),
('ATFCO', 'Str. Traian 42', '+373 (06) 187 677', 16),
('SCOTTI', 'Str. Sarmizecetusa 43', '+373 (06) 188 679', 17),
('GOODWILL', 'Str. Gradina Botanica 44', '+373 (06) 189 681', 18),
('CARPINI', 'Str. Puskin 45', '+373 (06) 190 683', 1),
('DIVELLA', 'Str. Alba-Iulia 46', '+373 (06) 191 685', 2);



INSERT INTO Magazin
	VALUES('LINELLA', 'Str. Independentii 25', '+373 207 124', 1),
('ECONOM', 'Str. Hristo-Botev 26', '+373 207 125', 2),
('Alimentara', 'Str. Grigore Vieru 27', '+373 207 126', 3),
('Vladalina SRL', 'Str. Albisoara 28', '+373 207 127', 4),
('Pegas', 'Str. Dacia 29', '+373 207 128', 6),
('NR 1', 'Str. Decebal 30', '+373 207 129', 5),
('YAY.md', 'Str. Burebista 31', '+373 207 130', 7),
('KAUFLAND', 'Str. Padurii 32', '+373 207 131', 8),
('FENIX', 'Str. Columna 33', '+373 207 132', 9),
('Nefis', 'Str. Basarabeasca 34', '+373 207 133', 10);


INSERT INTO Produs VALUES
('11221', 'MILKMARK LAPTE 3.5%', 930, 'ML', 16.95, '29-05-2022', 1, 1, 1),
('11222', 'SOLD DE PUI EXTRA REFRIGERAT', 1, 'kg', 78.90, '30-05-2022', 2, 6, 1),
('11223', 'PARIZER LACTA', 0.5, 'KG', 65.50, '28-05-2022', 3, 8, 1),
('11224', 'CRENVURȘTI CARMEZ', 0.5, 'KG', 63.95, '29-05-2022', 3, 7, 1),
('11225', 'FILE DE HERING KIRA ÎN ULEI', 0.2, 'KG', 30.75, '28-05-2023', 4, 15, 1),
('11226', 'MORCOV IUTE', 0.4, 'KG', 24.50, '29-05-2023', 5, 20, 1),
('11227', 'BAGHETĂ ARTIZANALĂ', 0.3, 'KG', 9.35, '28-05-2024', 6, 21, 1),
('11228', 'TORT PRAGA NOSTALGIE', 1, 'KG', 235.90, '29-05-2024', 7, 36, 1),
('11229', 'PATE DE PORC', 0.3, 'KG', 23.95, '28-05-2025', 8, 38, 1),
('11230', 'VIN PERLANT COLLECTION ROSE ALB DEMIDULCE', 0.75, 'L', 74.65, '29-05-2025', 14, 80, 1),
('11231', 'VIN SPUMANT GLERA ALB SEC DOZĂ', 0.25, 'L', 21.50, '28-05-2026', 14, 81, 1),
('11232', 'BĂUTURĂ SLAB ALCOOLICĂ BLACK CURRANT DULCE', 0.75, 'L', 67.50, '29-05-2026', 14, 82, 1),
('11233', 'TOCATURA DE PORC REFRIGERAT', 1, 'KG', 95.00, '01-05-2022', 2, 7, 2),
('11234', 'ȘUNCĂ CU CARNE DE VITĂ', 1, 'buc', 127.50, '02-06-2022', 3, 9, 2),
('11235', 'GUSTERĂ ZVÎNTATĂ', 1, 'KG', 95.00, '30-05-2022', 4, 19, 2),
('11236', 'SOMON AFUMAT FELIAT', 150, 'g', 127.00, '29-05-2022', 4, 15, 2),
('11237', 'VARZĂ DE MARE', 0.4, 'KG', 29.50, '28-05-2022', 5, 20, 2),
('11238', 'RULADA CU MAC', 250, 'g', 22.95, '01-05-2022', 6, 30, 2),
('11239', 'VITALLEO CARNE DE PORC', 350, 'g', 29.95, '02-06-2022', 8, 37, 2),
('11240', 'VINETE COAPTE CONGELATE', 0.4, 'KG', 28.75, '30-05-2022', 9, 52, 2),
('11241', 'CARTOFI PAI', 1, 'KG', 37.90, '29-05-2022', 9, 51, 2),
('11242', 'CEAI ROYAL GOJI & WILD STRAWBERRY', 25, 'pac.', 38.80, '28-05-2022', 10, 61, 2),
('11243', 'BOMBOANE SARM MIX', 276, 'g', 84.50, '01-05-2022', 11, 64, 2),
('11244', 'BOMBOANE CARRE MILK TRUFFLE', 200, 'g', 27.50, '02-06-2022', 11, 63, 3),
('11245', 'CHIPSURI CU GUST DE PAPRIKA', 215, 'g', 34.90, '30-05-2022', 12, 69, 3),
('11246', 'CHIPSURI CU SARE', 216, 'g', 34.91, '29-05-2022', 12, 69, 3),
('11247', 'CHIPS NACHO CHEESE', 100, 'g', 19.00, '28-05-2022', 12, 70, 3),
('11248', 'CHEFIR 2.5%', 750, 'ML', 21.95, '01-05-2022', 1, 2, 3),
('11249', 'IAURT CU COACĂZĂ 2.5%', 290, 'g', 21.75, '02-06-2022', 1, 2, 3),
('11250', 'CREMĂ DE BRÂNZĂ ZI DE ZI VIȘINĂ 5%', 250, 'g', 16.05, '30-05-2022', 1, 4, 3),
('11251', 'GAMBE DE PUI MARINATE REFRIGERAT', 1, 'KG', 88.00, '29-05-2022', 2, 6, 3),
('11252', 'CIRNACIORI DE BAVARIA REFRIGERAT CASEROLA', 1, 'KG', 109.00, '28-05-2022', 2, 7, 3),
('11253', ' SALEAMI CRUD-ZVINTAT MILANO DE PORC', 70, 'g', 49.00, '01-05-2022', 3, 12, 3),
('11254', 'MUȘCHI DE PORC FIERT-AFUMAT', 0.5, 'KG', 76.45, '02-06-2022', 3, 10, 3),
('11255', 'ROSIOARA EVISCERATA ZVANTATA', 1, 'KG', 235.00, '30-05-2022', 4, 19, 4),
('11256', 'SOS CHUTNEY CU PERE PENTRU PUI', 230, 'g', 59.45, '29-05-2022', 5, 25, 4),
('11257', 'MAIONEZĂ PROVANSAL', 400, 'ML', 33.60, '28-05-2022', 5, 24, 4),
('11258', 'GOGOAȘĂ CU CREMĂ DE NUCI 2X71G', 2, 'buc.', 27.50, '01-05-2022', 6, 34, 4),
('11259', 'PESMEȚI BRUSCHETTE CU GRAHAM', 130, 'g', 10.30, '02-06-2022', 6, 29, 4),
('11260', 'PÂINE CU SPELȚĂ ȘI SEMINȚE DE CHIA', 300, 'g', 10.15, '30-05-2022', 6, 27, 4),
('11261', 'TORT TIRAMISU', 0.9, 'KG', 150.00, '29-05-2022', 7, 30, 4),
('11262', 'TORT SMÂNTĂNEL SECTIONAT', 1.4, 'KG', 266.90, '28-05-2022', 7, 36, 4),
('11263', 'TORT POVESTE DE CIOCOLATĂ', 1, 'KG', 109.10, '01-05-2022', 7, 29, 4),
('11264', 'CREMĂ DE CIOCOLATĂ', 700, 'g', 95.00, '02-06-2022', 8, 48, 4),
('11265', 'FILE DE SOMON PRĂJIT ÎN SOS DE MUȘTAR', 160, 'g', 65.50, '30-05-2022', 8, 40, 4),
('11266', 'ȘAMPINIOANE MARINATE, FELIATE', 530, 'g', 47.00, '29-05-2022', 8, 45, 5),
('11267', 'ALUAT FOIETAJ CLASIC FĂRĂ DROJDIE PORȚIONAT', 800, 'g', 36.35, '28-05-2022', 9, 30, 5),
('11268', 'ÎNGHEȚATĂ PLOMBIR CIOCOLATĂ', 500, 'g', 37.25, '01-05-2022', 9, 56, 5),
('11269', 'ÎNGHEȚATĂ WHY NOT NEW', 80, 'g', 12.55, '02-06-2022', 9, 57, 5),
('11270', 'ÎNGHEȚATĂ ADAGIO ZMEURĂ/MANGO', 550, 'g', 55.95, '30-05-2022', 9, 58, 5),
('11271', 'CAFEA BOABE ESPRESSO CREMOSO', 1, 'KG', 211.00, '29-05-2022', 10, 60, 5),
('11272', 'CEAI NEGRU ENGLISH EDITION', 25, 'pac.', 41.75, '28-05-2022', 10, 62, 5),
('11273', 'CIOCOLATĂ AERATĂ EXTRA NEAGRĂ', 80, 'g', 18.70, '01-05-2022', 11, 68, 5),
('11274', 'CIOCOLATĂ MAXI', 123, 'g', 38.20, '02-06-2022', 11, 67, 5),
('11275', 'POPCORN PENTRU MICROUNDE CU UNT', 80, 'g', 13.40, '30-05-2022', 12, 72, 5),
('11276', 'BĂUTURĂ CARBOGAZOASĂ ORANGE', 1.25, 'L', 15.80, '29-05-2022', 13, 76, 5),
('11277', 'ĂUTURĂ CARBOGAZOASĂ', 1.25, 'L', 18.80, '28-05-2022', 13, 77, 6),
('11278', 'BĂUTURĂ RĂCORITOARE ROSE', 1.5, 'L', 15.20, '01-05-2022', 13, 78, 6),
('11279', 'VIN CHARDONNAY ALB SEC', 0.187, 'L', 32.20, '02-06-2022', 14, 79, 6),
('11280', 'VIN SPUMANT ROZE DULCE LACRIMA DULCE', 750, 'ML', 76.50, '30-05-2022', 14, 79, 6),
('11281', 'ZAHAR', 5, 'KG', 74.95, '01-05-2022', 15, 85, 6),
('11282', 'SARE IODATA', 1, 'KG', 9.75, '02-06-2022', 15, 86, 6),
('11283', 'FĂINĂ ALBĂ DIN GRÂU CALITATE SUPERIOARĂ', 2, 'KG', 32.95, '30-05-2022', 15, 87, 6),
('11284', 'OREZ BOB CU BOB CAMOLINO', 1, 'KG', 25.75, '29-05-2022', 15, 89, 6),
('11285', 'ARPACAȘ DIN ORZ', 900, 'g', 9.90, '28-05-2022', 15, 86, 6),
('11286', 'PASTE FĂINOASE RAVIOLI CARNE DE PUI', 500, 'g', 137.00, '01-05-2022', 15, 91, 6),
('11287', 'PASTE FĂINOASE PROASPETE PAGLIA/FIENO', 350, 'g', 79.00, '02-06-2022', 15, 91, 6),
('11288', 'PASTE PENNE ZITI RIGATI №27', 500, 'g', 15.95, '30-05-2022', 15, 92, 6),
('11289', 'FULGI DE HRIȘCĂ', 420, 'g', 32.95, '01-05-2022', 15, 90, 6),
('11290', 'BERE BLONDĂ ORIGINAL', 2.5, 'L', 51.50, '02-06-2022', 14, 83, 6);
