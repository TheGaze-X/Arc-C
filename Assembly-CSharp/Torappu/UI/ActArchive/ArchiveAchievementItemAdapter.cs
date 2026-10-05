using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AE1 RID: 27361
	[Token(Token = "0x2006AE1")]
	public class ArchiveAchievementItemAdapter : LoopScrollAdapter<ArchiveAchievementItemHolder, AchievementItemModel>
	{
		// Token: 0x06027223 RID: 160291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027223")]
		[Address(RVA = "0x224FC60", Offset = "0x224E860", VA = "0x18224FC60", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ArchiveAchievementItemHolder holder, AchievementItemModel data)
		{
		}

		// Token: 0x06027224 RID: 160292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027224")]
		[Address(RVA = "0x224FBB0", Offset = "0x224E7B0", VA = "0x18224FBB0", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06027225 RID: 160293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027225")]
		[Address(RVA = "0x224FDB0", Offset = "0x224E9B0", VA = "0x18224FDB0")]
		public ArchiveAchievementItemAdapter()
		{
		}

		// Token: 0x040375B1 RID: 226737
		[Token(Token = "0x40375B1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _prefabItem;

		// Token: 0x040375B2 RID: 226738
		[Token(Token = "0x40375B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040375B3 RID: 226739
		[Token(Token = "0x40375B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040375B4 RID: 226740
		[Token(Token = "0x40375B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
