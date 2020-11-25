using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsGL.OpenGL;


namespace CG_tet_1
{
    class Cgtest : OpenGLControl
    {
        protected override void InitGLContext()
        {
            base.InitGLContext();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
        }

        public override void glDraw()
        {
            base.glDraw();
            // point
            // circle
            drawpoint();

        }





   
        public void drawpoint()
        {
 
         
            GL.glLineWidth(6.0f);
            GL.glBegin(GL.GL_LINES);
           
            GL.glColor3d(1,0,0);
            
            GL.glVertex3d(-0.5, 0.5, 0);
            GL.glVertex3d(0.5, 0.5,0);

            GL.glVertex3d(-0.5, -0.5, 0);
            GL.glVertex3d(0.5, -0.5, 0);


            GL.glVertex3d(0.5, 0.5, 0);
            GL.glVertex3d(0.5, -0.5, 0);

            GL.glVertex3d(-0.5,0.5, 0);
            GL.glVertex3d(-0.5, -0.5, 0);

            
            GL.glEnd();
            GL.glLineWidth(9.0f);
            GL.glBegin(GL.GL_POLYGON);
            GL.glColor3d(255, 255, 0);
            GL.glVertex3d(0.25, 0.25, 0);
            GL.glVertex3d(0.29, 0.25, 0);
            GL.glVertex3d(0.29, 0.29, 0);
            GL.glVertex3d(0.25, 0.29, 0);
          
           GL.glEnd();
           GL.glFlush();

           GL.glLineWidth(3.0f);
           GL.glBegin(GL.GL_POLYGON);
        
           GL.glVertex3d(-0.25, 0.25, 0);
           GL.glVertex3d(-0.29, 0.25, 0);
           GL.glVertex3d(-0.29, 0.29, 0);
           GL.glVertex3d(-0.25, 0.29, 0);

           GL.glEnd();
           GL.glFlush();



           GL.glBegin(GL.GL_LINES);
           
           GL.glVertex3d(0, 0.25, 0);
           GL.glVertex3d(0, 0, 0);
           GL.glEnd();

           GL.glBegin(GL.GL_LINES);
           GL.glColor3d(0, 204, 255);
           GL.glVertex3d(-0.24, 0.06, 0);
           GL.glVertex3d(0, -0.19, 0);
           GL.glEnd();


           GL.glBegin(GL.GL_LINES);
           GL.glVertex3d(0.24, 0.06, 0);
           GL.glVertex3d(0, -0.19, 0);
           GL.glEnd();




           GL.glBegin(GL.GL_LINES);
           GL.glColor3d(255, 0, 191);
           
           GL.glVertex3d(0, 0.5, 0);
           GL.glVertex3d(-0.2, 0.7, 0);

        
           GL.glVertex3d(-0.2, 0.7, 0);
           GL.glVertex3d(-0.2, 0.5, 0);


           GL.glVertex3d(0, 0.5, 0);
           GL.glVertex3d(0.2, 0.7, 0);

           GL.glVertex3d(0.2, 0.7, 0);
           GL.glVertex3d(0.2, 0.5, 0);

     


           GL.glEnd();






        

        }


   
    }
}


