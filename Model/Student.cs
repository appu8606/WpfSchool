using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSchool.Model
{
 
    public class Student :  INotifyPropertyChanged 
    {

        private string _name;
        private Details _details;
        public string Name { get { return _name; } set { _name = value; RaisePropertyChanged("Name"); }  } 
        public Details details { get { return _details; } set { _details= value; RaisePropertyChanged("Details"); } }

       

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


    }


    public class Details : INotifyPropertyChanged
    {
        private string _subcode;
        private Subject _subject;
        private double _totmarks;
        public String Subcode { get { return _subcode; } set { _subcode = value; RaisePropertyChanged("Subcode"); } }

        public Subject MySubject
        {
            get { return _subject; }
            set { _subject = value; RaisePropertyChanged("Subject"); }
        }

        public double TotMarks { get { return _totmarks; } set { _totmarks = value; RaisePropertyChanged("TotMarks"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }

    public enum Subject { English, Maths, Hindi, Science, Social };
    public class Marks : INotifyPropertyChanged
    {
        public double English { get; set; }
        public double Maths { get; set; }
        public double Science { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
