namespace RefactoringsTest2021
{
    public abstract class ConvertAbstractClassToInterface
    {
        public abstract int Id { get; set; }
        public virtual void Register() { }
        public abstract void UnRegister();
    }

    class ConvertAbstractClassToInterfaceImpl : ConvertAbstractClassToInterface
    {
        public override int Id { get; set; }
        public override void Register()
        {
            throw new System.NotImplementedException();
        }

        public override void UnRegister()
        {
            throw new System.NotImplementedException();
        }
    }
}