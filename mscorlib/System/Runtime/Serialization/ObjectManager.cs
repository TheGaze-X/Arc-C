using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class ObjectManager
	{
		// Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0x4BA7DE0", Offset = "0x4BA69E0", VA = "0x184BA7DE0")]
		internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private bool CanCallGetType(object obj)
		{
			return default(bool);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000427")]
		internal object TopObject
		{
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000428")]
		internal ObjectHolderList SpecialFixupObjects
		{
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x4BA7E70", Offset = "0x4BA6A70", VA = "0x184BA7E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FD6")]
		[Address(RVA = "0x4BA5D00", Offset = "0x4BA4900", VA = "0x184BA5D00")]
		internal ObjectHolder FindObjectHolder(long objectID)
		{
			return null;
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FD7")]
		[Address(RVA = "0x4BA5D50", Offset = "0x4BA4950", VA = "0x184BA5D50")]
		internal ObjectHolder FindOrCreateObjectHolder(long objectID)
		{
			return null;
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FD8")]
		[Address(RVA = "0x4BA37F0", Offset = "0x4BA23F0", VA = "0x184BA37F0")]
		private void AddObjectHolder(ObjectHolder holder)
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x4BA6170", Offset = "0x4BA4D70", VA = "0x184BA6170")]
		private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing)
		{
			return default(bool);
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDA")]
		[Address(RVA = "0x4BA5EA0", Offset = "0x4BA4AA0", VA = "0x184BA5EA0")]
		private void FixupSpecialObject(ObjectHolder holder)
		{
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x6001FDB")]
		[Address(RVA = "0x4BA7B80", Offset = "0x4BA6780", VA = "0x184BA7B80")]
		private bool ResolveObjectReference(ObjectHolder holder)
		{
			return default(bool);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x6001FDC")]
		[Address(RVA = "0x4BA55E0", Offset = "0x4BA41E0", VA = "0x184BA55E0")]
		private bool DoValueTypeFixup(System.Reflection.FieldInfo memberToFix, ObjectHolder holder, object value)
		{
			return default(bool);
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x4BA3E40", Offset = "0x4BA2A40", VA = "0x184BA3E40")]
		internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
		{
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x4BA5440", Offset = "0x4BA4040", VA = "0x184BA5440")]
		private void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
		{
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x4BA66C0", Offset = "0x4BA52C0", VA = "0x184BA66C0", Slot = "4")]
		public virtual object GetObject(long objectID)
		{
			return null;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x4BA79F0", Offset = "0x4BA65F0", VA = "0x184BA79F0")]
		internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, System.Reflection.MemberInfo member)
		{
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x4BA72D0", Offset = "0x4BA5ED0", VA = "0x184BA72D0")]
		public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, System.Reflection.MemberInfo member, int[] arrayIndex)
		{
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x4BA3A80", Offset = "0x4BA2680", VA = "0x184BA3A80")]
		internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x4BA6590", Offset = "0x4BA5190", VA = "0x184BA6590")]
		internal static RuntimeConstructorInfo GetConstructor(RuntimeType t)
		{
			return null;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x4BA4F90", Offset = "0x4BA3B90", VA = "0x184BA4F90", Slot = "5")]
		public virtual void DoFixups()
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x4BA6F80", Offset = "0x4BA5B80", VA = "0x184BA6F80")]
		private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x4BA6CC0", Offset = "0x4BA58C0", VA = "0x184BA6CC0", Slot = "6")]
		public virtual void RecordFixup(long objectToBeFixed, System.Reflection.MemberInfo member, long objectRequired)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x4BA6B20", Offset = "0x4BA5720", VA = "0x184BA6B20", Slot = "7")]
		public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x4BA6980", Offset = "0x4BA5580", VA = "0x184BA6980", Slot = "8")]
		public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x4BA67B0", Offset = "0x4BA53B0", VA = "0x184BA67B0", Slot = "9")]
		public virtual void RaiseDeserializationEvent()
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x4BA3940", Offset = "0x4BA2540", VA = "0x184BA3940", Slot = "10")]
		internal virtual void AddOnDeserialization(DeserializationEventHandler handler)
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x4BA39E0", Offset = "0x4BA25E0", VA = "0x184BA39E0", Slot = "11")]
		internal virtual void AddOnDeserialized(object obj)
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x4BA6800", Offset = "0x4BA5400", VA = "0x184BA6800", Slot = "12")]
		internal virtual void RaiseOnDeserializedEvent(object obj)
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x4BA68C0", Offset = "0x4BA54C0", VA = "0x184BA68C0")]
		public void RaiseOnDeserializingEvent(object obj)
		{
		}

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DeserializationEventHandler m_onDeserializationHandler;

		// Token: 0x040010C2 RID: 4290
		[Token(Token = "0x40010C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SerializationEventHandler m_onDeserializedHandler;

		// Token: 0x040010C3 RID: 4291
		[Token(Token = "0x40010C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal ObjectHolder[] m_objects;

		// Token: 0x040010C4 RID: 4292
		[Token(Token = "0x40010C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal object m_topObject;

		// Token: 0x040010C5 RID: 4293
		[Token(Token = "0x40010C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal ObjectHolderList m_specialFixupObjects;

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal long m_fixupCount;

		// Token: 0x040010C7 RID: 4295
		[Token(Token = "0x40010C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal ISurrogateSelector m_selector;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal StreamingContext m_context;
	}
}
