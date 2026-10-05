using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004063 RID: 16483
	[Token(Token = "0x2004063")]
	public class SandboxV2AdminMainTypeItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x14000082 RID: 130
		// (add) Token: 0x060197F3 RID: 104435 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060197F4 RID: 104436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000082")]
		public event Action<int> eClick
		{
			[Token(Token = "0x60197F3")]
			[Address(RVA = "0x1231790", Offset = "0x1230390", VA = "0x181231790")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60197F4")]
			[Address(RVA = "0x12318F0", Offset = "0x12304F0", VA = "0x1812318F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060197F5 RID: 104437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197F5")]
		[Address(RVA = "0x1231600", Offset = "0x1230200", VA = "0x181231600")]
		public void SetConfig(Color selBgClr, Color selTitleClr)
		{
		}

		// Token: 0x060197F6 RID: 104438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197F6")]
		[Address(RVA = "0x1231490", Offset = "0x1230090", VA = "0x181231490")]
		public void Render(int idx, SandboxV2AdminMainTypeItemData data, int selected)
		{
		}

		// Token: 0x060197F7 RID: 104439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197F7")]
		[Address(RVA = "0x1231420", Offset = "0x1230020", VA = "0x181231420")]
		public void EventOnClick()
		{
		}

		// Token: 0x17003CBE RID: 15550
		// (get) Token: 0x060197F8 RID: 104440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003CBE")]
		public GameObject tutorialOnly_hotspotGO
		{
			[Token(Token = "0x60197F8")]
			[Address(RVA = "0x1231890", Offset = "0x1230490", VA = "0x181231890")]
			get
			{
				return null;
			}
		}

		// Token: 0x060197F9 RID: 104441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60197F9")]
		[Address(RVA = "0x1231730", Offset = "0x1230330", VA = "0x181231730")]
		public SandboxV2AdminMainTypeItem()
		{
		}

		// Token: 0x0401FC6B RID: 130155
		[Token(Token = "0x401FC6B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _normalTitle;

		// Token: 0x0401FC6C RID: 130156
		[Token(Token = "0x401FC6C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _selTitle;

		// Token: 0x0401FC6D RID: 130157
		[Token(Token = "0x401FC6D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0401FC6E RID: 130158
		[Token(Token = "0x401FC6E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x0401FC6F RID: 130159
		[Token(Token = "0x401FC6F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0401FC70 RID: 130160
		[Token(Token = "0x401FC70")]
		[FieldOffset(Offset = "0x40")]
		private int m_idx;

		// Token: 0x0401FC72 RID: 130162
		[Token(Token = "0x401FC72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_eClick;

		// Token: 0x0401FC73 RID: 130163
		[Token(Token = "0x401FC73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_eClick;

		// Token: 0x0401FC74 RID: 130164
		[Token(Token = "0x401FC74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetConfig;

		// Token: 0x0401FC75 RID: 130165
		[Token(Token = "0x401FC75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401FC76 RID: 130166
		[Token(Token = "0x401FC76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0401FC77 RID: 130167
		[Token(Token = "0x401FC77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_tutorialOnly_hotspotGO;

		// Token: 0x0401FC78 RID: 130168
		[Token(Token = "0x401FC78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
