using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Core.Controls.ObjectExplorer
{
    /// <summary>
    /// Ветвь обозревателя объектов.<br />
    /// Логика взаимодействия для ExplorerBranch.xaml
    /// </summary>
    public partial class ExplorerBranch : UserControl
    {
        /// <summary>
        /// Дочерние элементы ветви (зависимое свойство).
        /// </summary>
        public static readonly DependencyProperty ChildrenProperty =
            DependencyProperty.Register(nameof(Children), typeof(ItemCollection), typeof(ExplorerBranch));


        /// <summary>
        /// Иконка ветви (зависимое свойство).
        /// </summary>
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(BitmapImage), typeof(ExplorerBranch));


        /// <summary>
        /// Текст ветви (зависимое свойство).
        /// </summary>
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(ExplorerBranch));



        /// <summary>
        /// Событие изменения коллекции дочерних элементов.
        /// </summary>
        public event Action ChildrenChanged;



        public ExplorerBranch()
        {
            InitializeComponent();
            Children = itemsControl.Items;

            ChildrenChanged += ExplorerBranch_ChildrenChanged;
        }



        /// <summary>
        /// Дочерние элементы ветви.
        /// </summary>
        private ItemCollection Children
        {
            get => (ItemCollection)GetValue(ChildrenProperty);
            set => SetValue(ChildrenProperty, value);
        }


        /// <summary>
        /// Иконка ветви.
        /// </summary>
        public BitmapImage Icon
        {
            get => (BitmapImage)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }


        /// <summary>
        /// Текст ветви.
        /// </summary>
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }



        /// <summary>
        /// Обрабатывает событие изменения коллекции дочерних элементов.
        /// </summary>
        private void ExplorerBranch_ChildrenChanged()
        {
            if (Children.Count > 0)
                arrorIcon.Visibility = Visibility.Visible;
            else
                arrorIcon.Visibility = Visibility.Hidden;
        }


        /// <summary>
        /// Обработка события нажатия на иконку "свернуть-развернуть".
        /// </summary>
        /// <param name="sender">Объект, вызвавший событие.</param>
        /// <param name="e">Аргументы.</param>
        private void ArrorIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (itemsControl.Visibility == Visibility.Visible)
                Wrap();
            else
                Unwrap();
        }


        /// <summary>
        /// Сворачивает ветвь.
        /// </summary>
        private void Wrap()
        {
            itemsControl.Visibility = Visibility.Hidden;
            arrorIcon.Source = (BitmapImage)Application.Current.FindResource("ArrorRightIcon");
        }


        /// <summary>
        /// Разворачивает ветвь.
        /// </summary>
        private void Unwrap()
        {
            itemsControl.Visibility = Visibility.Visible;
            arrorIcon.Source = (BitmapImage)Application.Current.FindResource("ArrorCornerFillIcon");
        }


        /// <summary>
        /// Добавляет дочерний элемент в коллекцию.
        /// </summary>
        /// <param name="child">Дочерний элемент.</param>
        public void AddChild(ExplorerBranch child)
        {
            Children.Add(child);
            ChildrenChanged.Invoke();
        }


        /// <summary>
        /// Удаляет дочерний элемент из коллекции.
        /// </summary>
        /// <param name="child">Дочерний элемент.</param>
        public void RemoveChild(ExplorerBranch child)
        {
            Children.Remove(child);
            ChildrenChanged.Invoke();
        }
    }
}