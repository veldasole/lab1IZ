using System;
using System.Collections.ObjectModel;
using library.Model;


namespace library.ViewModel
{
    public class PublisherViewModel
    {
        public ObservableCollection<Publish> ListPublish { get; set; } =
        new ObservableCollection<Publish>();
        public PublisherViewModel()
        {
            this.ListPublish.Add(
            new Publish
            {
                Id = 1,
                NamePublisher = "АСТ",
                Address = "129085, г. Москва, б-р Звёздный, 21, стр. 1, ком. 705, ПОМ.",
                Site = "https://ast.ru/"
            });
            this.ListPublish.Add(
            new Publish
            {
                Id = 2,
                NamePublisher = "Эксмо",
                Address = "город Москва улица Зорге дом 1 строение 1 этаж 20 КАБ 2013.",
                Site = "https://eksmo.ru/"
            });
        }
    }
}
