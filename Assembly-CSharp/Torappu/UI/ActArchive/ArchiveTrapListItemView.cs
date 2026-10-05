using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C55 RID: 27733
	[Token(Token = "0x2006C55")]
	public class ArchiveTrapListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D8D RID: 23949
		// (get) Token: 0x06027968 RID: 162152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027969 RID: 162153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D8D")]
		public ArchiveTrapController controller
		{
			[Token(Token = "0x6027968")]
			[Address(RVA = "0x22C67F0", Offset = "0x22C53F0", VA = "0x1822C67F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027969")]
			[Address(RVA = "0x22C6850", Offset = "0x22C5450", VA = "0x1822C6850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602796A RID: 162154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602796A")]
		[Address(RVA = "0x22C6720", Offset = "0x22C5320", VA = "0x1822C6720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602796B RID: 162155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602796B")]
		[Address(RVA = "0x22C60F0", Offset = "0x22C4CF0", VA = "0x1822C60F0")]
		public void OnTrapItemClicked()
		{
		}

		// Token: 0x0602796C RID: 162156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602796C")]
		[Address(RVA = "0x22C6210", Offset = "0x22C4E10", VA = "0x1822C6210")]
		public void Render(TrapItemModel itemModel, string selectItemId = "")
		{
		}

		// Token: 0x0602796D RID: 162157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602796D")]
		[Address(RVA = "0x22C6790", Offset = "0x22C5390", VA = "0x1822C6790")]
		public ArchiveTrapListItemView()
		{
		}

		// Token: 0x0403823E RID: 229950
		[Token(Token = "0x403823E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403823F RID: 229951
		[Token(Token = "0x403823F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04038240 RID: 229952
		[Token(Token = "0x4038240")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnattained;

		// Token: 0x04038241 RID: 229953
		[Token(Token = "0x4038241")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelIcon;

		// Token: 0x04038242 RID: 229954
		[Token(Token = "0x4038242")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLockedIcon;

		// Token: 0x04038243 RID: 229955
		[Token(Token = "0x4038243")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgSmallIcon;

		// Token: 0x04038244 RID: 229956
		[Token(Token = "0x4038244")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textOrder;

		// Token: 0x04038245 RID: 229957
		[Token(Token = "0x4038245")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04038246 RID: 229958
		[Token(Token = "0x4038246")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x04038247 RID: 229959
		[Token(Token = "0x4038247")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04038248 RID: 229960
		[Token(Token = "0x4038248")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _trapDesc;

		// Token: 0x04038249 RID: 229961
		[Token(Token = "0x4038249")]
		[FieldOffset(Offset = "0x70")]
		private TrapItemModel m_cachedModel;

		// Token: 0x0403824A RID: 229962
		[Token(Token = "0x403824A")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0403824C RID: 229964
		[Token(Token = "0x403824C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0403824D RID: 229965
		[Token(Token = "0x403824D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0403824E RID: 229966
		[Token(Token = "0x403824E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403824F RID: 229967
		[Token(Token = "0x403824F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrapItemClicked;

		// Token: 0x04038250 RID: 229968
		[Token(Token = "0x4038250")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038251 RID: 229969
		[Token(Token = "0x4038251")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
