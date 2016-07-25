
CREATE TABLE tbl_frm_moneda2 (
                id_moneda2 INT IDENTITY NOT NULL,
                mnd_moneda2 VARCHAR(20) NOT NULL,
                mnd_abreviatura2 VARCHAR(5) NOT NULL,
                mnd_tipo_cambio FLOAT NOT NULL,
                CONSTRAINT id_moneda PRIMARY KEY (id_moneda2)
)

CREATE TABLE tbl_frm_usuario (
                id_usuario INT IDENTITY NOT NULL,
                usr_usuario VARCHAR(15) NOT NULL,
                usr_password VARCHAR(15) NOT NULL,
                CONSTRAINT id_usuario PRIMARY KEY (id_usuario)
)

CREATE TABLE tbl_frm_empresa2 (
                id_empresa2 INT IDENTITY NOT NULL,
                emp_nombre_empresa2 VARCHAR(25) NOT NULL,
                emp_direccion VARCHAR(40) NOT NULL,
                emp_telefono VARCHAR(8) NOT NULL,
                emp_nit VARCHAR(15) NOT NULL,
                CONSTRAINT id_empresa PRIMARY KEY (id_empresa2)
)

CREATE TABLE tbl_frm_transacciones (
                id_transacciones INT IDENTITY NOT NULL,
                tsc_id_presupuesto_uno INT NOT NULL,
                tsc_presupuesto_uno VARCHAR(25) NOT NULL,
                tsc_id_presupuesto_dos INT NOT NULL,
                tsc_presupuesto_dos VARCHAR(25) NOT NULL,
                tsc_cantidad FLOAT NOT NULL,
                tsc_fecha_transaccion DATETIME NOT NULL,
                tsc_usuario_transaccion INT NOT NULL,
                id_empresa2 INT NOT NULL,
                CONSTRAINT id_transacciones PRIMARY KEY (id_transacciones)
)

CREATE TABLE tbl_frm_presupuesto_gva (
                id_presupuesto_gva INT IDENTITY NOT NULL,
                gva_nombre VARCHAR(25) NOT NULL,
                gva_periodo DATETIME NOT NULL,
                gva_subventa FLOAT NOT NULL,
                gva_subadmin FLOAT NOT NULL,
                gva_grantotal FLOAT,
                id_empresa2 INT NOT NULL,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_presupuesto_gva PRIMARY KEY (id_presupuesto_gva)
)

CREATE TABLE tbl_frm_gastosadmin (
                id_gastosadmin INT IDENTITY NOT NULL,
                id_presupuesto_gva INT NOT NULL,
                gaa_nombre VARCHAR(25) NOT NULL,
                gaa_valor FLOAT NOT NULL,
                CONSTRAINT id_gastosadmin PRIMARY KEY (id_gastosadmin, id_presupuesto_gva)
)

CREATE TABLE tbl_frm_gastosventa (
                id_gastosv INT IDENTITY NOT NULL,
                id_presupuesto_gva INT NOT NULL,
                gav_nombre VARCHAR(25) NOT NULL,
                gav_valor FLOAT NOT NULL,
                CONSTRAINT id_gastosv PRIMARY KEY (id_gastosv, id_presupuesto_gva)
)

CREATE TABLE tbl_frm_presupuesto_cv (
                id_presupuesto_cv INT IDENTITY NOT NULL,
                pcv_nombre VARCHAR(25) NOT NULL,
                pcv_periodo DATETIME NOT NULL,
                pcv_grantotal FLOAT,
                id_empresa2 INT NOT NULL,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_presupuesto_cv PRIMARY KEY (id_presupuesto_cv)
)

CREATE TABLE tbl_frm_presupuesto_ici (
                id_presupuesto_ici INT IDENTITY NOT NULL,
                ici_nombre VARCHAR(25) NOT NULL,
                ici_periodo DATETIME NOT NULL,
                id_empresa2 INT NOT NULL,
                ici_grantotal FLOAT,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_presupuesto_ici PRIMARY KEY (id_presupuesto_ici)
)

CREATE TABLE tbl_frm_imp_costosind (
                id_imp_costoind INT IDENTITY NOT NULL,
                id_presupuesto_ici INT NOT NULL,
                imp_nombre VARCHAR(25) NOT NULL,
                imp_subtotal FLOAT NOT NULL,
                CONSTRAINT id_imp_costoind PRIMARY KEY (id_imp_costoind, id_presupuesto_ici)
)

CREATE TABLE tbl_frm_presupuesto_mod (
                id_presupuesto_mod INT IDENTITY NOT NULL,
                mod_nombre VARCHAR(25) NOT NULL,
                mod_periodo DATETIME NOT NULL,
                mod_grantotal_manoobradirecta FLOAT,
                id_empresa2 INT NOT NULL,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_presupuesto_mod PRIMARY KEY (id_presupuesto_mod)
)

CREATE TABLE tbl_frm_compras_matdirectos (
                id_compras_matdirectos INT IDENTITY NOT NULL,
                cmd_nombre VARCHAR(30) NOT NULL,
                cmd_periodo DATETIME NOT NULL,
                cmd_grantotal_matdirectos_compra FLOAT,
                id_empresa2 INT NOT NULL,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_compras_matdirectos PRIMARY KEY (id_compras_matdirectos)
)

CREATE TABLE tbl_frm_costos_equivalentes (
                id_costos_equivalentes INT IDENTITY NOT NULL,
                id_compras_matdirectos INT NOT NULL,
                id_presupuesto_mod INT NOT NULL,
                id_presupuesto_ici INT NOT NULL,
                id_presupuesto_cv INT NOT NULL,
                ceq_almacen_artterminados_estimado FLOAT NOT NULL,
                ceq_produccion_proceso_inv_estimado FLOAT NOT NULL,
                ceq_resta_matd_invmatd FLOAT NOT NULL,
                ceq_costo_matd_traspasadosp FLOAT NOT NULL,
                ceq_total_costo_produccion FLOAT NOT NULL,
                ceq_total_prod_proceso FLOAT NOT NULL,
                ceq_produccion_proceso_inv_deseado FLOAT NOT NULL,
                ceq_costprod_artterminados FLOAT NOT NULL,
                ceq_costart_termdispo FLOAT NOT NULL,
                ceq_almacen_artterminados_deseado FLOAT NOT NULL,
                CONSTRAINT id_costos_equivalentes PRIMARY KEY (id_costos_equivalentes, id_compras_matdirectos, id_presupuesto_mod, id_presupuesto_ici, id_presupuesto_cv)
)

CREATE TABLE tbl_frm_presupuesto_produccion2 (
                id_presupuesto_produccion2 INT IDENTITY NOT NULL,
                prp_nombre2 VARCHAR(30) NOT NULL,
                prp_periodo2 DATETIME NOT NULL,
                id_empresa2 INT NOT NULL,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_presupuesto_produccion PRIMARY KEY (id_presupuesto_produccion2)
)

CREATE TABLE tbl_frm_presupuesto_ventas2 (
                id_presupuesto_ventas2 INT IDENTITY NOT NULL,
                prv_nombre_presupuesto2 VARCHAR(30) NOT NULL,
                prv_periodo2 DATETIME NOT NULL,
                prv_volumen_total2 FLOAT NOT NULL,
                prv_total_producto2 FLOAT NOT NULL,
                id_empresa2 INT NOT NULL,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_presupuesto_ventas PRIMARY KEY (id_presupuesto_ventas2)
)

CREATE TABLE tbl_frm_estadoresultados (
                id_estadoresultados INT IDENTITY NOT NULL,
                id_presupuesto_ventas INT NOT NULL,
                id_presupuesto_cv INT NOT NULL,
                id_presupuesto_gva INT NOT NULL,
                erp_nombre VARCHAR(25) NOT NULL,
                erp_periodo DATETIME NOT NULL,
                erp_utilidad_bruta FLOAT NOT NULL,
                erp_utilidad_operacion FLOAT NOT NULL,
                erp_ingresos_gastos FLOAT NOT NULL,
                erp_utilidad_aisr FLOAT NOT NULL,
                erp_isr FLOAT NOT NULL,
                erp_utilidad_neta FLOAT NOT NULL,
                id_empresa2 INT NOT NULL,
                id_usuario INT NOT NULL,
                id_moneda2 INT NOT NULL,
                CONSTRAINT id_estadoresultados PRIMARY KEY (id_estadoresultados, id_presupuesto_ventas, id_presupuesto_cv, id_presupuesto_gva)
)

CREATE TABLE tbl_frm_producto2 (
                id_producto2 INT IDENTITY NOT NULL,
                id_presupuesto_ventas2 INT NOT NULL,
                pro_nombre_producto2 VARCHAR(25) NOT NULL,
                pro_volumen_unidad2 FLOAT NOT NULL,
                pro_precio_unidad2 FLOAT NOT NULL,
                pro_subtotal2 FLOAT NOT NULL,
                CONSTRAINT id_producto PRIMARY KEY (id_producto2, id_presupuesto_ventas2)
)

CREATE TABLE tbl_frm_produccion2 (
                id_produccion2 INT IDENTITY NOT NULL,
                id_presupuesto_produccion2 INT NOT NULL,
                prd_inventario_final_deseado2 FLOAT NOT NULL,
                prd_total2 FLOAT NOT NULL,
                prd_inventario_inicial_estimado2 FLOAT NOT NULL,
                prd_unidades_totales_producir2 FLOAT NOT NULL,
                id_producto2 INT NOT NULL,
                id_presupuesto_ventas2 INT NOT NULL,
                CONSTRAINT id_produccion PRIMARY KEY (id_produccion2, id_presupuesto_produccion2)
)

CREATE TABLE tbl_frm_manoobra (
                id_manoobra INT IDENTITY NOT NULL,
                id_presupuesto_mod INT NOT NULL,
                mao_nombre VARCHAR(30) NOT NULL,
                mao_horasunidad FLOAT NOT NULL,
                mao_tarifahora VARCHAR NOT NULL,
                mao_total_manoobra FLOAT NOT NULL,
                mod_grantotal_manoobradirecta FLOAT NOT NULL,
                id_produccion INT NOT NULL,
                id_presupuesto_produccion INT NOT NULL,
                CONSTRAINT id_manoobra PRIMARY KEY (id_manoobra, id_presupuesto_mod)
)

CREATE TABLE tbl_frm_materiales (
                id_materiales INT IDENTITY NOT NULL,
                id_compras_matdirectos INT NOT NULL,
                mat_nombre_matdirecto VARCHAR(25) NOT NULL,
                mat_inventario_deseado FLOAT NOT NULL,
                mat_total_deseado FLOAT NOT NULL,
                mat_inventario_estimado FLOAT NOT NULL,
                mat_total_estimado FLOAT NOT NULL,
                mat_precio_unitario FLOAT NOT NULL,
                mat_subtotal_matdirecto FLOAT NOT NULL,
                mat_total_matdirectos_compra FLOAT NOT NULL,
                id_produccion INT NOT NULL,
                id_presupuesto_produccion INT NOT NULL,
                CONSTRAINT id_materiales PRIMARY KEY (id_materiales, id_compras_matdirectos)
)

ALTER TABLE tbl_frm_presupuesto_ventas2 ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_presupuesto_ventas2_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_compras_matdirectos ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_compras_matdirectos_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_mod ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_presupuesto_mod_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_ici ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_presupuesto_ici_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_cv ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_presupuesto_cv_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_gva ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_presupuesto_gva_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_estadoresultados ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_estadoresultados_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_produccion2 ADD CONSTRAINT tbl_frm_moneda2_tbl_frm_presupuesto_produccion2_fk
FOREIGN KEY (id_moneda2)
REFERENCES tbl_frm_moneda2 (id_moneda2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_ventas2 ADD CONSTRAINT tbl_frm_usuario_tbl_frm_presupuesto_ventas2_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_produccion2 ADD CONSTRAINT tbl_frm_usuario_tbl_frm_presupuesto_produccion2_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_compras_matdirectos ADD CONSTRAINT tbl_frm_usuario_tbl_frm_compras_matdirectos_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_mod ADD CONSTRAINT tbl_frm_usuario_tbl_frm_presupuesto_mod_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_ici ADD CONSTRAINT tbl_frm_usuario_tbl_frm_presupuesto_ici_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_cv ADD CONSTRAINT tbl_frm_usuario_tbl_frm_presupuesto_cv_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_gva ADD CONSTRAINT tbl_frm_usuario_tbl_frm_presupuesto_gva_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_estadoresultados ADD CONSTRAINT tbl_frm_usuario_tbl_frm_estadoresultados_fk
FOREIGN KEY (id_usuario)
REFERENCES tbl_frm_usuario (id_usuario)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_ventas2 ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_presupuesto_ventas2_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_produccion2 ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_presupuesto_produccion2_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_compras_matdirectos ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_compras_matdirectos_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_mod ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_presupuesto_mod_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_ici ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_presupuesto_ici_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_cv ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_presupuesto_cv_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_presupuesto_gva ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_presupuesto_gva_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_estadoresultados ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_estadoresultados_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_transacciones ADD CONSTRAINT tbl_frm_empresa2_tbl_frm_transacciones_fk
FOREIGN KEY (id_empresa2)
REFERENCES tbl_frm_empresa2 (id_empresa2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_estadoresultados ADD CONSTRAINT tbl_frm_presupuesto_gva_tbl_frm_estadoresultados_fk
FOREIGN KEY (id_presupuesto_gva)
REFERENCES tbl_frm_presupuesto_gva (id_presupuesto_gva)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_gastosventa ADD CONSTRAINT tbl_frm_presupuesto_gva_tbl_frm_gastosventa_fk
FOREIGN KEY (id_presupuesto_gva)
REFERENCES tbl_frm_presupuesto_gva (id_presupuesto_gva)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_gastosadmin ADD CONSTRAINT tbl_frm_presupuesto_gva_tbl_frm_gastosadmin_fk
FOREIGN KEY (id_presupuesto_gva)
REFERENCES tbl_frm_presupuesto_gva (id_presupuesto_gva)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_costos_equivalentes ADD CONSTRAINT tbl_frm_presupuesto_cv_tbl_frm_costos_equivalentes_fk
FOREIGN KEY (id_presupuesto_cv)
REFERENCES tbl_frm_presupuesto_cv (id_presupuesto_cv)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_estadoresultados ADD CONSTRAINT tbl_frm_presupuesto_cv_tbl_frm_estadoresultados_fk
FOREIGN KEY (id_presupuesto_cv)
REFERENCES tbl_frm_presupuesto_cv (id_presupuesto_cv)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_imp_costosind ADD CONSTRAINT tbl_frm_presupuesto_ici_tbl_frm_imp_costosind_fk
FOREIGN KEY (id_presupuesto_ici)
REFERENCES tbl_frm_presupuesto_ici (id_presupuesto_ici)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_costos_equivalentes ADD CONSTRAINT tbl_frm_presupuesto_ici_tbl_frm_costos_equivalentes_fk
FOREIGN KEY (id_presupuesto_ici)
REFERENCES tbl_frm_presupuesto_ici (id_presupuesto_ici)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_manoobra ADD CONSTRAINT tbl_frm_presupuesto_mod_id_manoobra_fk
FOREIGN KEY (id_presupuesto_mod)
REFERENCES tbl_frm_presupuesto_mod (id_presupuesto_mod)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_costos_equivalentes ADD CONSTRAINT tbl_frm_presupuesto_mod_tbl_frm_costos_equivalentes_fk
FOREIGN KEY (id_presupuesto_mod)
REFERENCES tbl_frm_presupuesto_mod (id_presupuesto_mod)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_materiales ADD CONSTRAINT tbl_frm_compras_matdirectos_tbl_frm_materiales_fk
FOREIGN KEY (id_compras_matdirectos)
REFERENCES tbl_frm_compras_matdirectos (id_compras_matdirectos)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_costos_equivalentes ADD CONSTRAINT tbl_frm_compras_matdirectos_tbl_frm_costos_equivalentes_fk
FOREIGN KEY (id_compras_matdirectos)
REFERENCES tbl_frm_compras_matdirectos (id_compras_matdirectos)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_produccion2 ADD CONSTRAINT tbl_frm_presupuesto_produccion_tbl_frm_produccion_fk
FOREIGN KEY (id_presupuesto_produccion2)
REFERENCES tbl_frm_presupuesto_produccion2 (id_presupuesto_produccion2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_producto2 ADD CONSTRAINT tbl_frm_presupuesto_ventas_tbl_frm_producto_fk
FOREIGN KEY (id_presupuesto_ventas2)
REFERENCES tbl_frm_presupuesto_ventas2 (id_presupuesto_ventas2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_estadoresultados ADD CONSTRAINT tbl_frm_presupuesto_ventas_tbl_frm_estadoresultados_fk
FOREIGN KEY (id_presupuesto_ventas)
REFERENCES tbl_frm_presupuesto_ventas2 (id_presupuesto_ventas2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_produccion2 ADD CONSTRAINT tbl_frm_producto_tbl_frm_produccion_fk
FOREIGN KEY (id_producto2, id_presupuesto_ventas2)
REFERENCES tbl_frm_producto2 (id_producto2, id_presupuesto_ventas2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_materiales ADD CONSTRAINT tbl_frm_produccion_tbl_frm_materiales_fk
FOREIGN KEY (id_produccion, id_presupuesto_produccion)
REFERENCES tbl_frm_produccion2 (id_produccion2, id_presupuesto_produccion2)
ON DELETE NO ACTION
ON UPDATE NO ACTION

ALTER TABLE tbl_frm_manoobra ADD CONSTRAINT tbl_frm_produccion_id_manoobra_fk
FOREIGN KEY (id_produccion, id_presupuesto_produccion)
REFERENCES tbl_frm_produccion2 (id_produccion2, id_presupuesto_produccion2)
ON DELETE NO ACTION
ON UPDATE NO ACTION
