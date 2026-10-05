using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050EB RID: 20715
	[Token(Token = "0x20050EB")]
	public class DebugLoggerAdapter : RecycleLoopScrollAdapter<LogItemViewHolder, UIDebugLogger.Log>
	{
		// Token: 0x0601E9EB RID: 125419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E9EB")]
		[Address(RVA = "0x184F490", Offset = "0x184E090", VA = "0x18184F490", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601E9EC RID: 125420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9EC")]
		[Address(RVA = "0x184F310", Offset = "0x184DF10", VA = "0x18184F310", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x0601E9ED RID: 125421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9ED")]
		[Address(RVA = "0x184F370", Offset = "0x184DF70", VA = "0x18184F370", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, LogItemViewHolder holder, UIDebugLogger.Log viewModel)
		{
		}

		// Token: 0x0601E9EE RID: 125422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9EE")]
		[Address(RVA = "0x184F540", Offset = "0x184E140", VA = "0x18184F540")]
		public DebugLoggerAdapter()
		{
		}

		// Token: 0x040290AF RID: 168111
		[Token(Token = "0x40290AF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _logItem;

		// Token: 0x040290B0 RID: 168112
		[Token(Token = "0x40290B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040290B1 RID: 168113
		[Token(Token = "0x40290B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x040290B2 RID: 168114
		[Token(Token = "0x40290B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040290B3 RID: 168115
		[Token(Token = "0x40290B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
