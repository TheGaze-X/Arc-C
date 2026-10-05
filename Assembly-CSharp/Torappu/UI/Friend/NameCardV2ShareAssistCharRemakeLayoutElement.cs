using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DBF RID: 19903
	[Token(Token = "0x2004DBF")]
	public class NameCardV2ShareAssistCharRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DC16 RID: 121878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC16")]
		[Address(RVA = "0x175CAB0", Offset = "0x175B6B0", VA = "0x18175CAB0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC17 RID: 121879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC17")]
		[Address(RVA = "0x175CF00", Offset = "0x175BB00", VA = "0x18175CF00")]
		public NameCardV2ShareAssistCharRemakeLayoutElement()
		{
		}

		// Token: 0x040275D9 RID: 161241
		[Token(Token = "0x40275D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _charEmpty;

		// Token: 0x040275DA RID: 161242
		[Token(Token = "0x40275DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _charObject;

		// Token: 0x040275DB RID: 161243
		[Token(Token = "0x40275DB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _charEliteIcon;

		// Token: 0x040275DC RID: 161244
		[Token(Token = "0x40275DC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _charSpecMaxPart;

		// Token: 0x040275DD RID: 161245
		[Token(Token = "0x40275DD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _charPortrait;

		// Token: 0x040275DE RID: 161246
		[Token(Token = "0x40275DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _charLevel;

		// Token: 0x040275DF RID: 161247
		[Token(Token = "0x40275DF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _charPotentialIcon;

		// Token: 0x040275E0 RID: 161248
		[Token(Token = "0x40275E0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _charSkillIcon;

		// Token: 0x040275E1 RID: 161249
		[Token(Token = "0x40275E1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _charEquipIcon;

		// Token: 0x040275E2 RID: 161250
		[Token(Token = "0x40275E2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _charHaveEquipObject;

		// Token: 0x040275E3 RID: 161251
		[Token(Token = "0x40275E3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _charNoEquipObject;

		// Token: 0x040275E4 RID: 161252
		[Token(Token = "0x40275E4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x040275E5 RID: 161253
		[Token(Token = "0x40275E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x040275E6 RID: 161254
		[Token(Token = "0x40275E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
