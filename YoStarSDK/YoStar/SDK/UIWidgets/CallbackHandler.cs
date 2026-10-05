using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YoStar.SDK.UIWidgets
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	public abstract class CallbackHandler : MonoBehaviour
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060005A4 RID: 1444
		[Token(Token = "0x17000055")]
		public abstract string[] Callbacks { [Token(Token = "0x60005A4")] get; }

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x5C25840", Offset = "0x5C24440", VA = "0x185C25840")]
		protected void Execute(string eventID, CallbackEventData eventData)
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x5C25920", Offset = "0x5C24520", VA = "0x185C25920")]
		public void RegisterListener(string eventID, UnityAction<CallbackEventData> call)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x5C25B30", Offset = "0x5C24730", VA = "0x185C25B30")]
		public void RemoveListener(string eventID, UnityAction<CallbackEventData> call)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected CallbackHandler()
		{
		}

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public List<CallbackHandler.Entry> delegates;

		// Token: 0x020000D5 RID: 213
		[Token(Token = "0x20000D5")]
		[Serializable]
		public class Entry
		{
			// Token: 0x060005A9 RID: 1449 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Entry()
			{
			}

			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			[FieldOffset(Offset = "0x10")]
			public string eventID;

			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4000324")]
			[FieldOffset(Offset = "0x18")]
			public CallbackHandler.CallbackEvent callback;
		}

		// Token: 0x020000D6 RID: 214
		[Token(Token = "0x20000D6")]
		[Serializable]
		public class CallbackEvent : UnityEvent<CallbackEventData>
		{
			// Token: 0x060005AA RID: 1450 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x5C25800", Offset = "0x5C24400", VA = "0x185C25800")]
			public CallbackEvent()
			{
			}
		}
	}
}
