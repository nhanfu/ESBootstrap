﻿using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuChi;

namespace Extensions
{
    public static class Renderer
    {
        public static Html EditButton(this Html html)
        {
            return html.TData.Button.ClassName("button small warning").I.ClassName("fa fa-edit").EndOf(ElementType.td.ToString());
        }

        public static Html ActionColumn(this Html html)
        {
            return html.Th.Span.ClassName("mif-folder-open fg-cyan").End.End;
        }

        public static Html Panel(this Html html)
        {
            return html.Div.Attr("data-role", "panel").ClassName("panel").Attr("data-cls-panel", "shadow-1");
        }

        public static Html SmallDatePicker(this Html html)
        {
            return html.SmallInput().Attr("type", "date");
        }

        public static Html SmallInput(this Html html)
        {
            return html.Input.ClassName("input-small").Attr("data-role", "input");
        }

        public static Html SmallDropDown<T>(this Html html, List<T> list, T selectedItem, string displayField = null, string valueField = null)
        {
            return html.Dropdown(list, selectedItem, displayField, valueField).ClassName("input-small").Attr("data-role", "select");
        }

        public static Html GridRow(this Html html)
        {
            return html.Div.ClassName("row");
        }

        public static Html GridCell(this Html html, int size)
        {
            return html.Div.ClassName("cell cell-" + size);
        }
    }
}
