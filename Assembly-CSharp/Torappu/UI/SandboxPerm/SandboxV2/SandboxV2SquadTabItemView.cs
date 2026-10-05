using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004443 RID: 17475
	[Token(Token = "0x2004443")]
	public class SandboxV2SquadTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x0601AB44 RID: 109380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003F61")]
		public GameObject btnGo
		{
			[Token(Token = "0x601AB44")]
			[Address(RVA = "0x13D22B0", Offset = "0x13D0EB0", VA = "0x1813D22B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x0601AB45 RID: 109381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AB46 RID: 109382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F62")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x601AB45")]
			[Address(RVA = "0x13D2310", Offset = "0x13D0F10", VA = "0x1813D2310")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AB46")]
			[Address(RVA = "0x13D2370", Offset = "0x13D0F70", VA = "0x1813D2370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AB47 RID: 109383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB47")]
		[Address(RVA = "0x13D2090", Offset = "0x13D0C90", VA = "0x1813D2090")]
		public void Render(int index, bool isSelect)
		{
		}

		// Token: 0x0601AB48 RID: 109384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB48")]
		[Address(RVA = "0x13D1F80", Offset = "0x13D0B80", VA = "0x1813D1F80")]
		public void EventOnItemClick()
		{
		}

		// Token: 0x0601AB49 RID: 109385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB49")]
		[Address(RVA = "0x13D2250", Offset = "0x13D0E50", VA = "0x1813D2250")]
		public SandboxV2SquadTabItemView()
		{
		}

		// Token: 0x04022189 RID: 139657
		[Token(Token = "0x4022189")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgBg;

		// Token: 0x0402218A RID: 139658
		[Token(Token = "0x402218A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textSquadIdx;

		// Token: 0x0402218B RID: 139659
		[Token(Token = "0x402218B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorBgUnselect;

		// Token: 0x0402218C RID: 139660
		[Token(Token = "0x402218C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorBgSelect;

		// Token: 0x0402218D RID: 139661
		[Token(Token = "0x402218D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colorTextUnselect;

		// Token: 0x0402218E RID: 139662
		[Token(Token = "0x402218E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorTextSelect;

		// Token: 0x0402218F RID: 139663
		[Token(Token = "0x402218F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnGo;

		// Token: 0x04022191 RID: 139665
		[Token(Token = "0x4022191")]
		[FieldOffset(Offset = "0x78")]
		private int m_index;

		// Token: 0x04022192 RID: 139666
		[Token(Token = "0x4022192")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_btnGo;

		// Token: 0x04022193 RID: 139667
		[Token(Token = "0x4022193")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onItemClick;

		// Token: 0x04022194 RID: 139668
		[Token(Token = "0x4022194")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x04022195 RID: 139669
		[Token(Token = "0x4022195")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022196 RID: 139670
		[Token(Token = "0x4022196")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnItemClick;

		// Token: 0x04022197 RID: 139671
		[Token(Token = "0x4022197")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
