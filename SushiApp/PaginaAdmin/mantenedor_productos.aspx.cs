﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SushiApp.PaginaAdmin
{
    public partial class mantenedor_productos1 : System.Web.UI.Page
    {
        wsProducto.ServiceProductoClient productoClient = new wsProducto.ServiceProductoClient();
        wsProducto.producto auxProducto = new wsProducto.producto();
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarGVProductos();
        }

        public void cargarGVProductos()
        {
            try
            {
                var listadto = productoClient.obtenerProducto();
                var nuevolistadto = (from o in listadto
                                     orderby o.productoId
                                     select new
                                     {
                                         Id = o.productoId,
                                         Nombre = o.nombreProducto,
                                         Porciones = o.porcionesProdcuto,
                                         Precio = o.precioProducto,
                                         Descripción = o.descripcionProducto,
                                         Disponibilidad = Convert.ToBoolean(o.disponibilidadProducto)
                                     }).ToList();

                gvProductos.DataSource = nuevolistadto;
                gvProductos.DataBind();
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo cargar GridView Cliente');</script>");
            }

        }
        //btn Buscar
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                auxProducto = productoClient.buscarProducto(Convert.ToInt32(txtIdproducto.Text));
                txtNombre.Text = auxProducto.nombreProducto;
                txtDescripcion.Text = auxProducto.descripcionProducto;
                imgFoto.ImageUrl = auxProducto.imagenProdcuto;
                txtRuta.Text = auxProducto.imagenProdcuto;
                txtPorcion.Text = Convert.ToString(auxProducto.porcionesProdcuto);
                txtPrecio.Text = Convert.ToString(auxProducto.precioProducto);
                txtCategoria.Text = Convert.ToString(auxProducto.categoriaProductoId);                
                //falta disponibilidad
                
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo buscar');</script>");
                return;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdproducto.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 || txtPorcion.Text.Trim().Length == 0 || txtPrecio.Text.Trim().Length == 0 || txtCategoria.Text.Trim().Length == 0 || txtRuta.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = productoClient.buscarProducto(Convert.ToInt32(this.txtIdproducto.Text)).productoId;
                    if (id2 == 0)
                    {
                        auxProducto.productoId = Convert.ToInt32(this.txtIdproducto.Text);
                        auxProducto.nombreProducto = this.txtNombre.Text;
                        auxProducto.descripcionProducto = this.txtDescripcion.Text;                        
                        auxProducto.imagenProdcuto = txtRuta.Text;
                        auxProducto.porcionesProdcuto = Convert.ToInt32(txtPorcion.Text);
                        auxProducto.precioProducto = Convert.ToInt32(txtPrecio.Text);
                        auxProducto.categoriaProductoId = Convert.ToInt32(txtCategoria.Text);
                        //datos en duro de disponibilidad                        
                        auxProducto.disponibilidadProducto = 'f';

                        productoClient.agregarProducto(auxProducto);
                        limpiar();
                        cargarGVProductos();
                    }
                    else
                    {
                        Response.Write("<script>alert('Ya existe');</script>");
                        return;
                    }
                }
                
            }
            catch (Exception)
            {

                Response.Write("<script>alert('No se pudo guardar');</script>");
            }
        }

        private bool limpiar()
        {
            bool cad = true;
            txtIdproducto.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPorcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            imgFoto.ImageUrl = "";
            txtRuta.Text = String.Empty;
            this.txtIdproducto.Focus();
            return cad;
        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                productoClient.eliminarProducto(Convert.ToInt32(txtIdproducto.Text));
                Response.Write("<script>alert('Eliminado Producto');</script>");
                cargarGVProductos();
                limpiar();
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo eliminar');</script>");

            }
        }

        protected void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                string path = FileUpload1.PostedFile.FileName;
                FileUpload1.SaveAs(path);
                imgFoto.ImageUrl = FileUpload1.PostedFile.FileName;
                txtRuta.Text = imgFoto.ImageUrl;
            }
            catch (Exception)
            {
                Response.Write("<script>alert('No se pudo cargar imagen');</script>");
            }
               
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdproducto.Text.Trim().Length == 0 || txtNombre.Text.Trim().Length == 0 || txtDescripcion.Text.Trim().Length == 0 || txtPorcion.Text.Trim().Length == 0 || txtPrecio.Text.Trim().Length == 0 || txtCategoria.Text.Trim().Length == 0 || txtRuta.Text.Trim().Length == 0)
                {
                    Response.Write("<script>alert('Ningún campo puede estar vacío');</script>");
                    return;
                }
                else
                {
                    int id2 = productoClient.buscarProducto(Convert.ToInt32(this.txtIdproducto.Text)).productoId;
                    if (id2 != 0)
                    {
                        auxProducto.productoId = Convert.ToInt32(this.txtIdproducto.Text);
                        auxProducto.nombreProducto = this.txtNombre.Text;
                        auxProducto.descripcionProducto = this.txtDescripcion.Text;
                        auxProducto.imagenProdcuto = txtRuta.Text;
                        auxProducto.porcionesProdcuto = Convert.ToInt32(txtPorcion.Text);
                        auxProducto.precioProducto = Convert.ToInt32(txtPrecio.Text);
                        auxProducto.categoriaProductoId = Convert.ToInt32(txtCategoria.Text);
                        //datos en duro de disponibilidad                        
                        auxProducto.disponibilidadProducto = 'f';

                        productoClient.modificarProducto(auxProducto);
                        Response.Write("<script>alert('Modificado correctamente');</script>");
                        limpiar();
                        cargarGVProductos();
                    }
                    else
                    {
                        Response.Write("<script>alert('no se pudo modificar');</script>");
                        return;
                    }
                }                
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Debe ingresar solo números en el Id');</script>");
            }
        }
    }
}