using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007943 RID: 31043
	[Token(Token = "0x2007943")]
	public class Act1ArcadeBadgeBookShareRemakeModelApplier : CrossAppShareRemakeModelApplier
	{
		// Token: 0x0602B8EC RID: 178412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8EC")]
		[Address(RVA = "0x276CA50", Offset = "0x276B650", VA = "0x18276CA50", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0602B8ED RID: 178413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8ED")]
		[Address(RVA = "0x276CF30", Offset = "0x276BB30", VA = "0x18276CF30")]
		public Act1ArcadeBadgeBookShareRemakeModelApplier()
		{
		}

		// Token: 0x0403F006 RID: 258054
		[Token(Token = "0x403F006")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _ultimateGroupNameText;

		// Token: 0x0403F007 RID: 258055
		[Token(Token = "0x403F007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _ultimateIconImage;

		// Token: 0x0403F008 RID: 258056
		[Token(Token = "0x403F008")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _ultimateTierImage;

		// Token: 0x0403F009 RID: 258057
		[Token(Token = "0x403F009")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _ultimateScoreText;

		// Token: 0x0403F00A RID: 258058
		[Token(Token = "0x403F00A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _zoneGroupNameText;

		// Token: 0x0403F00B RID: 258059
		[Token(Token = "0x403F00B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _zoneGroupLayoutContent;

		// Token: 0x0403F00C RID: 258060
		[Token(Token = "0x403F00C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _commonGroupNameText;

		// Token: 0x0403F00D RID: 258061
		[Token(Token = "0x403F00D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _commonGroupLayoutContent;

		// Token: 0x0403F00E RID: 258062
		[Token(Token = "0x403F00E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x0403F00F RID: 258063
		[Token(Token = "0x403F00F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
