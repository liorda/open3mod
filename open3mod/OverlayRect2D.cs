using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open3mod
{
    /// <summary>
    /// fixed-size billboard marker
    /// </summary>
    public static class OverlayRect2D
    {
        private static Color4 _defaultColor = new Color4(1.0f, 1.0f, 0.0f, 0.5f);

        public static void DrawRect2D(Vector3 position, uint size, bool fill = true, Color4? color = null)
        {
            Color4 col = (color == null) ? _defaultColor : (Color4)color;
            Vector2 pos2d = GetScreenCoordinates(position);

            GL.PushAttrib(AttribMask.LightingBit | AttribMask.PolygonBit);
            GL.Disable(EnableCap.Lighting);
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);

            GL.PushMatrix();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Vector4 viewPort = new Vector4();
            GL.GetFloat(GetPName.Viewport, out viewPort);
            GL.Ortho(viewPort.X, viewPort.X + viewPort.Z, viewPort.Y, viewPort.Y + viewPort.W, -1f, 1f);

            if (fill)
            {
                GL.Begin(BeginMode.Triangles);
                GL.Color4(col);

                float half = (size / 2);
                float x1 = pos2d.X - half;
                float y1 = pos2d.Y - half;
                float x2 = pos2d.X + half;
                float y2 = pos2d.Y + half;

                GL.Vertex2(x1, y1);
                GL.Vertex2(x2, y1);
                GL.Vertex2(x2, y2);

                GL.Vertex2(x1, y1);
                GL.Vertex2(x2, y2);
                GL.Vertex2(x1, y2);

                GL.End();
            }
            else
            {
                GL.Begin(BeginMode.Lines);
                GL.Color4(col);

                float half = (size / 2);
                float x1 = pos2d.X - half;
                float y1 = pos2d.Y - half;
                float x2 = pos2d.X + half;
                float y2 = pos2d.Y + half;

                GL.Vertex2(x1, y1); GL.Vertex2(x2, y1); // bottom
                GL.Vertex2(x1, y2); GL.Vertex2(x2, y2); // upper
                GL.Vertex2(x1, y1); GL.Vertex2(x1, y2); // left
                GL.Vertex2(x2, y1); GL.Vertex2(x2, y2); // right

                GL.End();
            }

            GL.PopAttrib();

            GL.PopMatrix();
        }

        #region helpers

        private static Vector2 GetScreenCoordinates(Vector3 ObjectCoordinate)
        {
            // adopted from http://stackoverflow.com/a/11427664

            Vector4 obj = new Vector4(ObjectCoordinate.X, ObjectCoordinate.Y, ObjectCoordinate.Z, 1.0f);
            Matrix4 projection = new Matrix4();
            Matrix4 modelView = new Matrix4();
            Vector4 viewPort = new Vector4();

            GL.GetFloat(GetPName.ModelviewMatrix, out modelView);
            GL.GetFloat(GetPName.ProjectionMatrix, out projection);
            GL.GetFloat(GetPName.Viewport, out viewPort);

            Vector4 eye = Vector4.Transform(obj, modelView);
            Vector4 clip = Vector4.Transform(eye, projection);
            Vector3 ndc = new Vector3(clip.X / clip.W, clip.Y / clip.W, clip.Z / clip.W);
            Vector2 w = new Vector2(viewPort.Z / 2 * ndc.X + viewPort.X + viewPort.Z / 2, viewPort.W / 2 * ndc.Y + viewPort.Y + viewPort.W / 2);

            return w;
        }

        #endregion
    }
}
