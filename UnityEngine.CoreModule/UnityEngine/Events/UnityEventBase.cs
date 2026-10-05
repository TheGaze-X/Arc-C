using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	[UsedByNativeCode]
	[Serializable]
	public abstract class UnityEventBase : ISerializationCallbackReceiver
	{
		// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x5977800", Offset = "0x5976400", VA = "0x185977800")]
		protected UnityEventBase()
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x59777F0", Offset = "0x59763F0", VA = "0x1859777F0", Slot = "4")]
		private void OnBeforeSerialize()
		{
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x59777F0", Offset = "0x59763F0", VA = "0x1859777F0", Slot = "5")]
		private void OnAfterDeserialize()
		{
		}

		// Token: 0x06000CBB RID: 3259
		[Token(Token = "0x6000CBB")]
		protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

		// Token: 0x06000CBC RID: 3260
		[Token(Token = "0x6000CBC")]
		internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x5976C00", Offset = "0x5975800", VA = "0x185976C00")]
		internal MethodInfo FindMethod(PersistentCall call)
		{
			return null;
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x5976E70", Offset = "0x5975A70", VA = "0x185976E70")]
		internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType)
		{
			return null;
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x5977240", Offset = "0x5975E40", VA = "0x185977240")]
		public int GetPersistentEventCount()
		{
			return 0;
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x5977330", Offset = "0x5975F30", VA = "0x185977330")]
		public Object GetPersistentTarget(int index)
		{
			return null;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x5977290", Offset = "0x5975E90", VA = "0x185977290")]
		public string GetPersistentMethodName(int index)
		{
			return null;
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x5976B20", Offset = "0x5975720", VA = "0x185976B20")]
		private void DirtyPersistentCalls()
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x5977620", Offset = "0x5976220", VA = "0x185977620")]
		private void RebuildPersistentCallsIfNeeded()
		{
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x5976AC0", Offset = "0x59756C0", VA = "0x185976AC0")]
		internal void AddCall(BaseInvokableCall call)
		{
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x5977730", Offset = "0x5976330", VA = "0x185977730")]
		protected void RemoveListener(object targetObj, MethodInfo method)
		{
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x5977660", Offset = "0x5976260", VA = "0x185977660")]
		public void RemoveAllListeners()
		{
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x5977540", Offset = "0x5976140", VA = "0x185977540")]
		internal List<BaseInvokableCall> PrepareInvoke()
		{
			return null;
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x5977750", Offset = "0x5976350", VA = "0x185977750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x59773A0", Offset = "0x5975FA0", VA = "0x1859773A0")]
		public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes)
		{
			return null;
		}

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x10")]
		private InvokableCallList m_Calls;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_PersistentListeners")]
		[SerializeField]
		private PersistentCallGroup m_PersistentCalls;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x20")]
		private bool m_CallsDirty;
	}
}
