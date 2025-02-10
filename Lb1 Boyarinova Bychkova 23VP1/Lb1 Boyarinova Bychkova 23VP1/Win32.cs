using System.Runtime.InteropServices;

namespace Lb1_Boyarinova_Bychkova_23VP1
{
    /// <summary>
    /// Класс для создания сообщения с помощью неуправляемого кода
    /// </summary>
    internal class Win32
    {
        /// <summary>
        /// Внешний метод для вызова нативной функции MessageBox из Windows API
        /// </summary>
        /// <param name="hWnd">Дескриптор родительского окна</param>
        /// <param name="text">Текст сообщщения</param>
        /// <param name="caption">Заголовок окна</param>
        /// <param name="type">Флаги стиля окна</param>
        /// <returns>Дескриптор окна</returns>
        //Дескриптор окна - уникальный идентификатор, который присваивает окну операционная система
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
        String caption, uint type);
    }

}
