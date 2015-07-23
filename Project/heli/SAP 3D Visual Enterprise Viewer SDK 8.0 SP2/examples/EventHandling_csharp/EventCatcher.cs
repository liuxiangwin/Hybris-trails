using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exploration3D;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections;
using System.Globalization;
using System.IO;

namespace EventHandling
{
    public delegate object ComEventDelegate(
        string name,
        BindingFlags invokeAttr,
        Binder binder,
        object target,
        object[] args,
        ParameterModifier[] modifiers,
        CultureInfo culture,
        string[] namedParameters);

    public class EventCatcher : IReflect
    {
        public ComEventDelegate Callback;

        object IReflect.InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
        {
            if(Callback == null)
                return null;

            return Callback(name, invokeAttr, binder, target, args, modifiers, culture, namedParameters);
        }

        public EventCatcher()
        {
        }

        public EventCatcher(ComEventDelegate callback)
        {
            Callback = callback;
        }

        // The rest of this class is just a harmless stub implementation..

        PropertyInfo[] IReflect.GetProperties(BindingFlags bindingAttr)
        {
            return this.GetType().GetProperties(bindingAttr);
        }

        FieldInfo[] IReflect.GetFields(BindingFlags bindingAttr)
        {
            return this.GetType().GetFields(bindingAttr);
        }

        MethodInfo[] IReflect.GetMethods(BindingFlags bindingAttr)
        {
            return this.GetType().GetMethods(bindingAttr);
        }

        MemberInfo[] IReflect.GetMembers(BindingFlags bindingAttr)
        {
            return this.GetType().GetMembers(bindingAttr);
        }

        FieldInfo IReflect.GetField(string name, BindingFlags bindingAttr)
        {
            return this.GetType().GetField(name, bindingAttr);
        }

        MemberInfo[] IReflect.GetMember(string name, BindingFlags bindingAttr)
        {
            return this.GetType().GetMember(name, bindingAttr);
        }

        MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr)
        {
            return this.GetType().GetMethod(name, bindingAttr);
        }

        MethodInfo IReflect.GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
        {
            return this.GetType().GetMethod(name, bindingAttr, binder, types, modifiers);
        }

        PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
        {
            return this.GetType().GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
        }

        PropertyInfo IReflect.GetProperty(string name, BindingFlags bindingAttr)
        {
            return this.GetType().GetProperty(name, bindingAttr);
        }

        Type IReflect.UnderlyingSystemType
        {
            get { return this.GetType().UnderlyingSystemType; }
        }
    }

}