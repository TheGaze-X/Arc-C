using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	[Serializable]
	internal class PersistentCallGroup
	{
		// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x5963E60", Offset = "0x5962A60", VA = "0x185963E60")]
		public PersistentCallGroup()
		{
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x1700029B")]
		public int Count
		{
			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x5963EF0", Offset = "0x5962AF0", VA = "0x185963EF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x5963C60", Offset = "0x5962860", VA = "0x185963C60")]
		public PersistentCall GetListener(int index)
		{
			return null;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x5963CC0", Offset = "0x59628C0", VA = "0x185963CC0")]
		public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
		}

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("m_Listeners")]
		private List<PersistentCall> m_Calls;
	}
}
