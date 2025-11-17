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
            var uc1 = new UCProyectoItem("Web Corporativa", "Diseño y desarrollo de la web de la empresa", 35);
            flowPanelProyectos.Controls.Add(uc1);

            var uc2 = new UCProyectoItem("App Móvil", "Creación de la app para iOS y Android", 50);
            flowPanelProyectos.Controls.Add(uc2);

            var uc3 = new UCProyectoItem("Base de Datos", "Optimización de consultas y estructura", 20);
            flowPanelProyectos.Controls.Add(uc3);

            var uc4 = new UCProyectoItem("Landing Page", "Página de promoción para campaña de marketing", 15);
            flowPanelProyectos.Controls.Add(uc4);

            var uc5 = new UCProyectoItem("Mantenimiento Servidor", "Actualizar servidores y parches de seguridad", 10);
            flowPanelProyectos.Controls.Add(uc5);

            var uc6 = new UCProyectoItem("SEO y Marketing", "Optimización para buscadores y estrategia digital", 25);
            flowPanelProyectos.Controls.Add(uc6);

            var uc7 = new UCProyectoItem("Dashboard Interno", "Panel de control para empleados", 40);
            flowPanelProyectos.Controls.Add(uc7);
            var uc8 = new UCProyectoItem("Sistema de Facturación", "Automatización de facturas y pagos", 45);
            flowPanelProyectos.Controls.Add(uc8);

            var uc9 = new UCProyectoItem("Integración API", "Conectar la app con servicios externos", 30);
            flowPanelProyectos.Controls.Add(uc9);

            var uc10 = new UCProyectoItem("Pruebas QA", "Testeo de funcionalidades y corrección de bugs", 18);
            flowPanelProyectos.Controls.Add(uc10);

            var uc11 = new UCProyectoItem("Migración Cloud", "Mover datos a servidores en la nube", 38);
            flowPanelProyectos.Controls.Add(uc11);

            var uc12 = new UCProyectoItem("Autenticación", "Implementar login con OAuth y seguridad", 22);
            flowPanelProyectos.Controls.Add(uc12);

            var uc13 = new UCProyectoItem("Notificaciones Push", "Enviar alertas a usuarios en tiempo real", 16);
            flowPanelProyectos.Controls.Add(uc13);

            var uc14 = new UCProyectoItem("Optimización Frontend", "Mejorar tiempos de carga y animaciones", 28);
            flowPanelProyectos.Controls.Add(uc14);

            var uc15 = new UCProyectoItem("Documentación Técnica", "Redactar manuales y guías internas", 12);
            flowPanelProyectos.Controls.Add(uc15);

            var uc16 = new UCProyectoItem("Análisis de Datos", "Estadísticas de uso y métricas clave", 33);
            flowPanelProyectos.Controls.Add(uc16);

            var uc17 = new UCProyectoItem("Sistema de Backup", "Copia y restauración de datos críticos", 20);
            flowPanelProyectos.Controls.Add(uc17);
            var t1 = new UCTareaItem("Instalar Windows", "Instalar y configurar Windows 11 en el PC de pruebas", 3);
            flowPanelTareas.Controls.Add(t1);

            var t2 = new UCTareaItem("Actualizar drivers", "Actualizar todos los drivers a la última versión", 1);
            flowPanelTareas.Controls.Add(t2);

            var t3 = new UCTareaItem("Configurar red", "Configurar red local y Wi-Fi", 2);
            flowPanelTareas.Controls.Add(t3);

            var t4 = new UCTareaItem("Backup datos", "Hacer copia de seguridad de todos los archivos importantes", 4);
            flowPanelTareas.Controls.Add(t4);

            var t5 = new UCTareaItem("Instalar antivirus", "Instalar antivirus y comprobar actualizaciones", 1);
            flowPanelTareas.Controls.Add(t5);

            var t6 = new UCTareaItem("Prueba de software", "Probar software nuevo en sandbox", 2);
            flowPanelTareas.Controls.Add(t6);

            var t7 = new UCTareaItem("Optimización PC", "Limpiar archivos temporales y optimizar arranque", 2);
            flowPanelTareas.Controls.Add(t7);

            var t8 = new UCTareaItem("Actualizar Office", "Actualizar suite Office a la última versión", 1);
            flowPanelTareas.Controls.Add(t8);

            var t9 = new UCTareaItem("Configurar impresora", "Instalar y configurar impresoras en red", 1);
            flowPanelTareas.Controls.Add(t9);

            var t10 = new UCTareaItem("Test de rendimiento", "Probar velocidad de CPU y RAM", 3);
            flowPanelTareas.Controls.Add(t10);

        }
    }
}
