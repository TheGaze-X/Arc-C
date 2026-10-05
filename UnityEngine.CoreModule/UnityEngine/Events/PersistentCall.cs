using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x0200018A RID: 394
	[Token(Token = "0x200018A")]
	[Serializable]
	internal class PersistentCall : ISerializationCallbackReceiver
	{
		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000296")]
		public Object target
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000297")]
		public string targetAssemblyTypeName
		{
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x59649B0", Offset = "0x59635B0", VA = "0x1859649B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000298")]
		public string methodName
		{
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x17000299")]
		public PersistentListenerMode mode
		{
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x59649A0", Offset = "0x59635A0", VA = "0x1859649A0")]
			get
			{
				return PersistentListenerMode.EventDefined;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029A")]
		public ArgumentCache arguments
		{
			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x5964990", Offset = "0x5963590", VA = "0x185964990")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x59648D0", Offset = "0x59634D0", VA = "0x1859648D0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x5964500", Offset = "0x5963100", VA = "0x185964500")]
		public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			return null;
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x5963F30", Offset = "0x5962B30", VA = "0x185963F30")]
		private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			return null;
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x5958C70", Offset = "0x5957870", VA = "0x185958C70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x5958C70", Offset = "0x5957870", VA = "0x185958C70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x5964910", Offset = "0x5963510", VA = "0x185964910")]
		public PersistentCall()
		{
		}

		// Token: 0x040005C6 RID: 1478
		[Token(Token = "0x40005C6")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("instance")]
		[SerializeField]
		private Object m_Target;

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_TargetAssemblyTypeName;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("methodName")]
		private string m_MethodName;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("mode")]
		[SerializeField]
		private PersistentListenerMode m_Mode;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("arguments")]
		private ArgumentCache m_Arguments;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("enabled")]
		[SerializeField]
		[FormerlySerializedAs("m_Enabled")]
		private UnityEventCallState m_CallState;
	}
}
