using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003686 RID: 13958
	[Token(Token = "0x2003686")]
	public abstract class BehaviourTransAction : MonoBehaviour, ITransAction
	{
		// Token: 0x06016347 RID: 90951
		[Token(Token = "0x6016347")]
		public abstract void Execute(State fromState, State toState, TransActionListener mustInvokeEnd);

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x06016348 RID: 90952
		[Token(Token = "0x17003560")]
		public abstract TransActionType ActionType { [Token(Token = "0x6016348")] get; }

		// Token: 0x06016349 RID: 90953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016349")]
		[Address(RVA = "0xE8EBF0", Offset = "0xE8D7F0", VA = "0x180E8EBF0", Slot = "9")]
		public virtual void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
		{
		}

		// Token: 0x0601634A RID: 90954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601634A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected BehaviourTransAction()
		{
		}

		// Token: 0x0401AAF1 RID: 109297
		[Token(Token = "0x401AAF1")]
		[HideInInspector]
		public const string ASSET_SUFIX = "_transaction";
	}
}
