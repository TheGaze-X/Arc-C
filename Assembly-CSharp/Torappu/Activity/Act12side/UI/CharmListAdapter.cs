using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A7E RID: 31358
	[Token(Token = "0x2007A7E")]
	public class CharmListAdapter : RecycleLoopScrollAdapter<CharmCardHolder, CharmModel>
	{
		// Token: 0x0602BEBE RID: 179902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEBE")]
		[Address(RVA = "0x27D45D0", Offset = "0x27D31D0", VA = "0x1827D45D0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, CharmCardHolder holder, CharmModel data)
		{
		}

		// Token: 0x0602BEBF RID: 179903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BEBF")]
		[Address(RVA = "0x27D4870", Offset = "0x27D3470", VA = "0x1827D4870", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602BEC0 RID: 179904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEC0")]
		[Address(RVA = "0x27D4930", Offset = "0x27D3530", VA = "0x1827D4930")]
		private void _TraceAVG(int position, CharmCardHolder holder)
		{
		}

		// Token: 0x0602BEC1 RID: 179905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEC1")]
		[Address(RVA = "0x27D4AB0", Offset = "0x27D36B0", VA = "0x1827D4AB0")]
		public CharmListAdapter()
		{
		}

		// Token: 0x0403F9DD RID: 260573
		[Token(Token = "0x403F9DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CharmCard _charmCardPrefab;

		// Token: 0x0403F9DE RID: 260574
		[Token(Token = "0x403F9DE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Enum(true, EnumDisplay.Checkbox, MaxItemsPerRow = 1)]
		private CharmCardMode _mode;

		// Token: 0x0403F9DF RID: 260575
		[Token(Token = "0x403F9DF")]
		[FieldOffset(Offset = "0x78")]
		public Action<CharmCard> onSelectChanged;

		// Token: 0x0403F9E0 RID: 260576
		[Token(Token = "0x403F9E0")]
		[FieldOffset(Offset = "0x80")]
		public Action onFirstCharmRegistered;

		// Token: 0x0403F9E1 RID: 260577
		[Token(Token = "0x403F9E1")]
		[FieldOffset(Offset = "0x88")]
		private bool m_avgTraceRegistered;

		// Token: 0x0403F9E2 RID: 260578
		[Token(Token = "0x403F9E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0403F9E3 RID: 260579
		[Token(Token = "0x403F9E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0403F9E4 RID: 260580
		[Token(Token = "0x403F9E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TraceAVG;

		// Token: 0x0403F9E5 RID: 260581
		[Token(Token = "0x403F9E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
