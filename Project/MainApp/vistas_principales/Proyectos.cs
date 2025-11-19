using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApp
{
    public partial class Proyectos : UserControl
    {
        public Proyectos()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            InicializarProyectosDePrueba();

            InicializarTareasDePrueba();
            int contproyectos = flowPanelProyectos.Controls.Count;
            int conttareas = flowPanelTareas.Controls.Count; // luego lo cambimos al conteo real
            lblproyectostareascont.Text = $"Proyecto/s: {contproyectos}   |   Tarea/s: {conttareas}";
        }

        private void InicializarTareasDePrueba()
        {

            // --- Sección de UCTareaItem ---
            // Lista de Tareas
            var now1 = DateTime.Now.Date;

            // Firma del constructor utilizada:
            // public UCTareaItem(int? id, int? projectid, int? designedEmp, string titulo, string descripcion, int horas, DateTime? startdate, DateTime? enddate, String priority = null, string status = null)

            var t1 = new UCTareaItem(1, 101, 1, "Instalar Windows", "Instalar y configurar Windows 11 en el PC de pruebas", 3, now1, null, "Alta", "Pendiente");
            flowPanelTareas.Controls.Add(t1);

            var t2 = new UCTareaItem(2, 101, 2, "Actualizar drivers", "Actualizar todos los drivers a la última versión", 1, now1, null, "Media", "En curso");
            flowPanelTareas.Controls.Add(t2);

            var t3 = new UCTareaItem(3, 101, 3, "Configurar red", "Configurar red local y Wi-Fi", 2, now1, null, "Alta", "Pendiente");
            flowPanelTareas.Controls.Add(t3);

            var t4 = new UCTareaItem(4, 102, 1, "Backup datos", "Hacer copia de seguridad de todos los archivos importantes", 4, now1, null, "Alta", "Pendiente");
            flowPanelTareas.Controls.Add(t4);

            var t5 = new UCTareaItem(5, 102, 2, "Instalar antivirus", "Instalar antivirus y comprobar actualizaciones", 1, now1, null, "Baja", "En curso");
            flowPanelTareas.Controls.Add(t5);

            var t6 = new UCTareaItem(6, 103, 3, "Prueba de software", "Probar software nuevo en sandbox", 2, now1, null, "Media", "Pendiente");
            flowPanelTareas.Controls.Add(t6);

            var t7 = new UCTareaItem(7, 103, 1, "Optimización PC", "Limpiar archivos temporales y optimizar arranque", 2, now1, null, "Baja", "En curso");
            flowPanelTareas.Controls.Add(t7);

            var t8 = new UCTareaItem(8, 104, 2, "Actualizar Office", "Actualizar suite Office a la última versión", 1, now1, null, "Media", "Pendiente");
            flowPanelTareas.Controls.Add(t8);

            var t9 = new UCTareaItem(9, 104, 3, "Configurar impresora", "Instalar y configurar impresoras en red", 1, now1, null, "Baja", "Pendiente");
            flowPanelTareas.Controls.Add(t9);

            var t10 = new UCTareaItem(10, 105, 1, "Test de rendimiento", "Probar velocidad de CPU y RAM", 3, now1, null, "Alta", "En curso");
            flowPanelTareas.Controls.Add(t10);
            /***/
        }

        private void InicializarProyectosDePrueba()
        {
            /* datos de ejemplo*/
            var now = DateTime.Now.Date;

            // Los datos proporcionados originalmente por el usuario se han reordenado e inyectado los faltantes.
            // Argumentos: id, title, description, startDate, enddate, prioridad, leaderId, estado, horas

            var uc1 = new UCProyectoItem(1, "Web Corporativa", "Diseño y desarrollo de la web de la empresa", now, null, "Alta", 1, "Pendiente", 35);
            flowPanelProyectos.Controls.Add(uc1);

            var uc2 = new UCProyectoItem(2, "App Móvil", "Creación de la app para iOS y Android", now, null, "Alta", 2, "En curso", 50);
            flowPanelProyectos.Controls.Add(uc2);

            var uc3 = new UCProyectoItem(3, "Base de Datos", "Optimización de consultas y estructura", now, null, "Media", 3, "Pendiente", 20);
            flowPanelProyectos.Controls.Add(uc3);

            var uc4 = new UCProyectoItem(4, "Landing Page", "Página de promoción para campaña de marketing", now, null, "Media", 1, "Pendiente", 15);
            flowPanelProyectos.Controls.Add(uc4);

            var uc5 = new UCProyectoItem(5, "Mantenimiento Servidor", "Actualizar servidores y parches de seguridad", now, null, "Alta", 2, "En curso", 10);
            flowPanelProyectos.Controls.Add(uc5);

            var uc6 = new UCProyectoItem(6, "SEO y Marketing", "Optimización para buscadores y estrategia digital", now, null, "Baja", 3, "Pendiente", 25);
            flowPanelProyectos.Controls.Add(uc6);

            var uc7 = new UCProyectoItem(7, "Dashboard Interno", "Panel de control para empleados", now, null, "Alta", 1, "En curso", 40);
            flowPanelProyectos.Controls.Add(uc7);

            var uc8 = new UCProyectoItem(8, "Sistema de Facturación", "Automatización de facturas y pagos", now, null, "Alta", 2, "Pendiente", 45);
            flowPanelProyectos.Controls.Add(uc8);

            var uc9 = new UCProyectoItem(9, "Integración API", "Conectar la app con servicios externos", now, null, "Media", 3, "Pendiente", 30);
            flowPanelProyectos.Controls.Add(uc9);

            var uc10 = new UCProyectoItem(10, "Pruebas QA", "Testeo de funcionalidades y corrección de bugs", now, null, "Media", 1, "En curso", 18);
            flowPanelProyectos.Controls.Add(uc10);

            var uc11 = new UCProyectoItem(11, "Migración Cloud", "Mover datos a servidores en la nube", now, null, "Alta", 2, "Pendiente", 38);
            flowPanelProyectos.Controls.Add(uc11);

            var uc12 = new UCProyectoItem(12, "Autenticación", "Implementar login con OAuth y seguridad", now, null, "Alta", 3, "Pendiente", 22);
            flowPanelProyectos.Controls.Add(uc12);

            var uc13 = new UCProyectoItem(13, "Notificaciones Push", "Enviar alertas a usuarios en tiempo real", now, null, "Baja", 1, "Pendiente", 16);
            flowPanelProyectos.Controls.Add(uc13);

            var uc14 = new UCProyectoItem(14, "Optimización Frontend", "Mejorar tiempos de carga y animaciones", now, null, "Media", 2, "Pendiente", 28);
            flowPanelProyectos.Controls.Add(uc14);

            var uc15 = new UCProyectoItem(15, "Documentación Técnica", "Redactar manuales y guías internas", now, null, "Baja", 3, "En curso", 12);
            flowPanelProyectos.Controls.Add(uc15);

            var uc16 = new UCProyectoItem(16, "Análisis de Datos", "Estadísticas de uso y métricas clave", now, null, "Alta", 1, "Pendiente", 33);
            flowPanelProyectos.Controls.Add(uc16);

            var uc17 = new UCProyectoItem(17, "Sistema de Backup", "Copia y restauración de datos críticos", now, null, "Alta", 2, "Pendiente", 20);
            flowPanelProyectos.Controls.Add(uc17);
        }

        private void nuevoProyectoClick(object sender, EventArgs e)
        {
            var frm = new NuevoProyecto();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new NuevaTarea();
            frm.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
