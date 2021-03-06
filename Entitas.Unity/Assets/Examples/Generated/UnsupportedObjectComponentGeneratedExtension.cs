//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public UnsupportedObjectComponent unsupportedObject { get { return (UnsupportedObjectComponent)GetComponent(ComponentIds.UnsupportedObject); } }

        public bool hasUnsupportedObject { get { return HasComponent(ComponentIds.UnsupportedObject); } }

        public Entity AddUnsupportedObject(UnsupportedObject newUnsupportedObject) {
            var component = CreateComponent<UnsupportedObjectComponent>(ComponentIds.UnsupportedObject);
            component.unsupportedObject = newUnsupportedObject;
            return AddComponent(ComponentIds.UnsupportedObject, component);
        }

        public Entity ReplaceUnsupportedObject(UnsupportedObject newUnsupportedObject) {
            var component = CreateComponent<UnsupportedObjectComponent>(ComponentIds.UnsupportedObject);
            component.unsupportedObject = newUnsupportedObject;
            ReplaceComponent(ComponentIds.UnsupportedObject, component);
            return this;
        }

        public Entity RemoveUnsupportedObject() {
            return RemoveComponent(ComponentIds.UnsupportedObject);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherUnsupportedObject;

        public static IMatcher UnsupportedObject {
            get {
                if (_matcherUnsupportedObject == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.UnsupportedObject);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherUnsupportedObject = matcher;
                }

                return _matcherUnsupportedObject;
            }
        }
    }
}
