using System;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200386A RID: 14442
	[Token(Token = "0x200386A")]
	public class UITimelyDropAssetHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016DE3 RID: 93667 RVA: 0x00093630 File Offset: 0x00091830
		[Token(Token = "0x6016DE3")]
		[Address(RVA = "0xF67700", Offset = "0xF66300", VA = "0x180F67700")]
		public bool TryToGetTimelyDropAsset(TimelyDropAssetType assetType, out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06016DE4 RID: 93668 RVA: 0x00093648 File Offset: 0x00091848
		[Token(Token = "0x6016DE4")]
		[Address(RVA = "0xF67E80", Offset = "0xF66A80", VA = "0x180F67E80")]
		private bool _TryToGetZoneSelectExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06016DE5 RID: 93669 RVA: 0x00093660 File Offset: 0x00091860
		[Token(Token = "0x6016DE5")]
		[Address(RVA = "0xF67BE0", Offset = "0xF667E0", VA = "0x180F67BE0")]
		public bool _TryToGetDropPicExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06016DE6 RID: 93670 RVA: 0x00093678 File Offset: 0x00091878
		[Token(Token = "0x6016DE6")]
		[Address(RVA = "0xF67A90", Offset = "0xF66690", VA = "0x180F67A90")]
		private bool _TryToGetDropPicAndApProtectExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06016DE7 RID: 93671 RVA: 0x00093690 File Offset: 0x00091890
		[Token(Token = "0x6016DE7")]
		[Address(RVA = "0xF67CC0", Offset = "0xF668C0", VA = "0x180F67CC0")]
		private bool _TryToGetStagePicExDrop(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06016DE8 RID: 93672 RVA: 0x000936A8 File Offset: 0x000918A8
		[Token(Token = "0x6016DE8")]
		[Address(RVA = "0xF67DA0", Offset = "0xF669A0", VA = "0x180F67DA0")]
		private bool _TryToGetStageTimelyDropStyle(out UnityEngine.Object result)
		{
			return default(bool);
		}

		// Token: 0x06016DE9 RID: 93673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016DE9")]
		[Address(RVA = "0xF67F60", Offset = "0xF66B60", VA = "0x180F67F60")]
		public UITimelyDropAssetHolder()
		{
		}

		// Token: 0x0401B951 RID: 112977
		[Token(Token = "0x401B951")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _zoneSelectExDrop;

		// Token: 0x0401B952 RID: 112978
		[Token(Token = "0x401B952")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dropPicExDrop;

		// Token: 0x0401B953 RID: 112979
		[Token(Token = "0x401B953")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _dropPicAndApProtectExDrop;

		// Token: 0x0401B954 RID: 112980
		[Token(Token = "0x401B954")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _stagePicExDrop;

		// Token: 0x0401B955 RID: 112981
		[Token(Token = "0x401B955")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StageTimelyDropStyle _stageTimelyDropStyle;

		// Token: 0x0401B956 RID: 112982
		[Token(Token = "0x401B956")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryToGetTimelyDropAsset;

		// Token: 0x0401B957 RID: 112983
		[Token(Token = "0x401B957")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryToGetZoneSelectExDrop;

		// Token: 0x0401B958 RID: 112984
		[Token(Token = "0x401B958")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryToGetDropPicExDrop;

		// Token: 0x0401B959 RID: 112985
		[Token(Token = "0x401B959")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryToGetDropPicAndApProtectExDrop;

		// Token: 0x0401B95A RID: 112986
		[Token(Token = "0x401B95A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryToGetStagePicExDrop;

		// Token: 0x0401B95B RID: 112987
		[Token(Token = "0x401B95B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryToGetStageTimelyDropStyle;

		// Token: 0x0401B95C RID: 112988
		[Token(Token = "0x401B95C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
