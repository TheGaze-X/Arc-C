using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	internal sealed class ReflectEventDescriptor : EventDescriptor
	{
		// Token: 0x06000CB4 RID: 3252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x5164CB0", Offset = "0x51638B0", VA = "0x185164CB0")]
		public ReflectEventDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
		{
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x5164B40", Offset = "0x5163740", VA = "0x185164B40")]
		public ReflectEventDescriptor(Type componentClass, EventInfo eventInfo)
		{
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x5164EE0", Offset = "0x5163AE0", VA = "0x185164EE0")]
		public ReflectEventDescriptor(Type componentType, EventDescriptor oldReflectEventDescriptor, Attribute[] attributes)
		{
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A0")]
		public override Type ComponentType
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A1")]
		public override Type EventType
		{
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x5164FE0", Offset = "0x5163BE0", VA = "0x185164FE0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x170002A2")]
		public override bool IsMulticast
		{
			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x5165000", Offset = "0x5163C00", VA = "0x185165000", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x5163610", Offset = "0x5162210", VA = "0x185163610", Slot = "20")]
		public override void AddEventHandler(object component, Delegate value)
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x5163A50", Offset = "0x5162650", VA = "0x185163A50", Slot = "15")]
		protected override void FillAttributes(IList attributes)
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x5163BE0", Offset = "0x51627E0", VA = "0x185163BE0")]
		private void FillEventInfoAttribute(EventInfo realEventInfo, IList attributes)
		{
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x5163F00", Offset = "0x5162B00", VA = "0x185163F00")]
		private void FillMethods()
		{
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x5164460", Offset = "0x5163060", VA = "0x185164460")]
		private void FillSingleMethodAttribute(MethodInfo realMethodInfo, IList attributes)
		{
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x51647C0", Offset = "0x51633C0", VA = "0x1851647C0", Slot = "21")]
		public override void RemoveEventHandler(object component, Delegate value)
		{
		}

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x60")]
		private Type _type;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x68")]
		private readonly Type _componentClass;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x70")]
		private MethodInfo _addMethod;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x78")]
		private MethodInfo _removeMethod;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x80")]
		private EventInfo _realEvent;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x88")]
		private bool _filledMethods;
	}
}
