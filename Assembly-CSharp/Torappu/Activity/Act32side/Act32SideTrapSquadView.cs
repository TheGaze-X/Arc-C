using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using Torappu.UI.TemplateTrap;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act32side
{
	// Token: 0x02007489 RID: 29833
	[Token(Token = "0x2007489")]
	public class Act32SideTrapSquadView : TemplateTrapSquadPlugin
	{
		// Token: 0x0602A12E RID: 172334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A12E")]
		[Address(RVA = "0x25BD7C0", Offset = "0x25BC3C0", VA = "0x1825BD7C0", Slot = "8")]
		public override void Show(SquadHomePlugin.PluginInputParams param)
		{
		}

		// Token: 0x0602A12F RID: 172335 RVA: 0x000D75F8 File Offset: 0x000D57F8
		[Token(Token = "0x602A12F")]
		[Address(RVA = "0x25BD760", Offset = "0x25BC360", VA = "0x1825BD760", Slot = "10")]
		public override bool ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0602A130 RID: 172336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A130")]
		[Address(RVA = "0x25BD640", Offset = "0x25BC240", VA = "0x1825BD640")]
		public void OpenTrapPage()
		{
		}

		// Token: 0x0602A131 RID: 172337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A131")]
		[Address(RVA = "0x25BDBD0", Offset = "0x25BC7D0", VA = "0x1825BDBD0")]
		public Act32SideTrapSquadView()
		{
		}

		// Token: 0x0602A132 RID: 172338 RVA: 0x000D7610 File Offset: 0x000D5810
		[Token(Token = "0x602A132")]
		[Address(RVA = "0x1872C40", Offset = "0x1871840", VA = "0x181872C40")]
		private bool <>xLuaBaseProxy_ShowSquadLeftArrow()
		{
			return default(bool);
		}

		// Token: 0x0403C642 RID: 247362
		[Token(Token = "0x403C642")]
		private const string UI_ICON_IMG = "{0}_icon";

		// Token: 0x0403C643 RID: 247363
		[Token(Token = "0x403C643")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _showObj;

		// Token: 0x0403C644 RID: 247364
		[Token(Token = "0x403C644")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<UIAtlasImage> _atlasImage;

		// Token: 0x0403C645 RID: 247365
		[Token(Token = "0x403C645")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasObject _atlasObj;

		// Token: 0x0403C646 RID: 247366
		[Token(Token = "0x403C646")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _newFlag;

		// Token: 0x0403C647 RID: 247367
		[Token(Token = "0x403C647")]
		[FieldOffset(Offset = "0x50")]
		private bool m_flagInfo;

		// Token: 0x0403C648 RID: 247368
		[Token(Token = "0x403C648")]
		[FieldOffset(Offset = "0x58")]
		private string m_stageId;

		// Token: 0x0403C649 RID: 247369
		[Token(Token = "0x403C649")]
		[FieldOffset(Offset = "0x60")]
		private string m_groupId;

		// Token: 0x0403C64A RID: 247370
		[Token(Token = "0x403C64A")]
		[FieldOffset(Offset = "0x68")]
		private string m_domainId;

		// Token: 0x0403C64B RID: 247371
		[Token(Token = "0x403C64B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403C64C RID: 247372
		[Token(Token = "0x403C64C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowSquadLeftArrow;

		// Token: 0x0403C64D RID: 247373
		[Token(Token = "0x403C64D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OpenTrapPage;

		// Token: 0x0403C64E RID: 247374
		[Token(Token = "0x403C64E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
