﻿namespace TinyLittleMvvm.Demo.ViewModels {
    public class SampleSubViewModel : PropertyChangedBase {
        private string _text;

        public string Text {
            get { return _text; }
            set {
                if (_text != value) {
                    _text = value;
                    NotifyOfPropertyChange(() => Text);
                }
            }
        }
    }
}