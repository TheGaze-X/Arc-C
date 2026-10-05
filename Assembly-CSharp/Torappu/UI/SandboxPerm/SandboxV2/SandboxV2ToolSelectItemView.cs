using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200444B RID: 17483
	[Token(Token = "0x200444B")]
	public class SandboxV2ToolSelectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x0601AB7C RID: 109436 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB7D RID: 109437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F6C")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x601AB7C")]
			[Address(RVA = "0x13E7210", Offset = "0x13E5E10", VA = "0x1813E7210")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB7D")]
			[Address(RVA = "0x13E7270", Offset = "0x13E5E70", VA = "0x1813E7270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AB7E RID: 109438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB7E")]
		[Address(RVA = "0x13E6F00", Offset = "0x13E5B00", VA = "0x1813E6F00")]
		public void Render(int position, SandboxV2SquadToolModel toolModel, bool isSelect, bool showIndex, int selectIdx)
		{
		}

		// Token: 0x0601AB7F RID: 109439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB7F")]
		[Address(RVA = "0x13E71B0", Offset = "0x13E5DB0", VA = "0x1813E71B0")]
		public SandboxV2ToolSelectItemView()
		{
		}

		// Token: 0x040221E9 RID: 139753
		[Token(Token = "0x40221E9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _selectGo;

		// Token: 0x040221EA RID: 139754
		[Token(Token = "0x40221EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textSelectIndex;

		// Token: 0x040221EB RID: 139755
		[Token(Token = "0x40221EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2SquadToolItemView _toolItemPrefab;

		// Token: 0x040221EC RID: 139756
		[Token(Token = "0x40221EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _toolItemRoot;

		// Token: 0x040221EE RID: 139758
		[Token(Token = "0x40221EE")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2SquadToolItemView m_toolItemView;

		// Token: 0x040221EF RID: 139759
		[Token(Token = "0x40221EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x040221F0 RID: 139760
		[Token(Token = "0x40221F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x040221F1 RID: 139761
		[Token(Token = "0x40221F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040221F2 RID: 139762
		[Token(Token = "0x40221F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
