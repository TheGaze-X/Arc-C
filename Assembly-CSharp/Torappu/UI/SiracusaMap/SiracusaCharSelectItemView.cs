using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F21 RID: 16161
	[Token(Token = "0x2003F21")]
	public class SiracusaCharSelectItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0601917D RID: 102781 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601917E RID: 102782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C06")]
		public Action<string> eventCharItemClick
		{
			[Token(Token = "0x601917D")]
			[Address(RVA = "0x11C9470", Offset = "0x11C8070", VA = "0x1811C9470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601917E")]
			[Address(RVA = "0x11C94D0", Offset = "0x11C80D0", VA = "0x1811C94D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601917F RID: 102783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601917F")]
		[Address(RVA = "0x11C93A0", Offset = "0x11C7FA0", VA = "0x1811C93A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019180 RID: 102784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019180")]
		[Address(RVA = "0x11C92B0", Offset = "0x11C7EB0", VA = "0x1811C92B0")]
		private string _GetItemIconPath(string spriteName)
		{
			return null;
		}

		// Token: 0x06019181 RID: 102785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019181")]
		[Address(RVA = "0x11C8B90", Offset = "0x11C7790", VA = "0x1811C8B90")]
		public void Init(AutoPackSpriteHub spriteHub)
		{
		}

		// Token: 0x06019182 RID: 102786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019182")]
		[Address(RVA = "0x11C8D30", Offset = "0x11C7930", VA = "0x1811C8D30")]
		public void Render(SiracusaCharSelectItemViewModel itemViewModel)
		{
		}

		// Token: 0x06019183 RID: 102787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019183")]
		[Address(RVA = "0x11C8C50", Offset = "0x11C7850", VA = "0x1811C8C50")]
		public void OnItemClick()
		{
		}

		// Token: 0x06019184 RID: 102788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019184")]
		[Address(RVA = "0x11C9410", Offset = "0x11C8010", VA = "0x1811C9410")]
		public SiracusaCharSelectItemView()
		{
		}

		// Token: 0x0401F0CF RID: 127183
		[Token(Token = "0x401F0CF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objStateHeadActive;

		// Token: 0x0401F0D0 RID: 127184
		[Token(Token = "0x401F0D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIDynImage _imgHead;

		// Token: 0x0401F0D1 RID: 127185
		[Token(Token = "0x401F0D1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objCompleteProgress;

		// Token: 0x0401F0D2 RID: 127186
		[Token(Token = "0x401F0D2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objProgressTxt;

		// Token: 0x0401F0D3 RID: 127187
		[Token(Token = "0x401F0D3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtProgress;

		// Token: 0x0401F0D4 RID: 127188
		[Token(Token = "0x401F0D4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objCompleteTag;

		// Token: 0x0401F0D5 RID: 127189
		[Token(Token = "0x401F0D5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objNewChar;

		// Token: 0x0401F0D6 RID: 127190
		[Token(Token = "0x401F0D6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objStateHeadUnknown;

		// Token: 0x0401F0D7 RID: 127191
		[Token(Token = "0x401F0D7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIDynImage _imgHeadUnknown;

		// Token: 0x0401F0D8 RID: 127192
		[Token(Token = "0x401F0D8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objHeadSelectedFrame;

		// Token: 0x0401F0D9 RID: 127193
		[Token(Token = "0x401F0D9")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0401F0DA RID: 127194
		[Token(Token = "0x401F0DA")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedCharId;

		// Token: 0x0401F0DB RID: 127195
		[Token(Token = "0x401F0DB")]
		private const string PROGRESS_TXT = "<size=21>{0}</size><size=15>/{1}</size>";

		// Token: 0x0401F0DC RID: 127196
		[Token(Token = "0x401F0DC")]
		[FieldOffset(Offset = "0x78")]
		private AutoPackSpriteHub m_charCardSpriteHub;

		// Token: 0x0401F0DE RID: 127198
		[Token(Token = "0x401F0DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventCharItemClick;

		// Token: 0x0401F0DF RID: 127199
		[Token(Token = "0x401F0DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventCharItemClick;

		// Token: 0x0401F0E0 RID: 127200
		[Token(Token = "0x401F0E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F0E1 RID: 127201
		[Token(Token = "0x401F0E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetItemIconPath;

		// Token: 0x0401F0E2 RID: 127202
		[Token(Token = "0x401F0E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401F0E3 RID: 127203
		[Token(Token = "0x401F0E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F0E4 RID: 127204
		[Token(Token = "0x401F0E4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0401F0E5 RID: 127205
		[Token(Token = "0x401F0E5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
