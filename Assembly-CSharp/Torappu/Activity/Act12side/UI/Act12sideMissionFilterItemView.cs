using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AB3 RID: 31411
	[Token(Token = "0x2007AB3")]
	public class Act12sideMissionFilterItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006722 RID: 26402
		// (get) Token: 0x0602C006 RID: 180230 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C007 RID: 180231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006722")]
		public Action<Act12SideData.ActZoneClass> onFilterSelected
		{
			[Token(Token = "0x602C006")]
			[Address(RVA = "0x27DF2C0", Offset = "0x27DDEC0", VA = "0x1827DF2C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602C007")]
			[Address(RVA = "0x27DF320", Offset = "0x27DDF20", VA = "0x1827DF320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602C008 RID: 180232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C008")]
		[Address(RVA = "0x27DF160", Offset = "0x27DDD60", VA = "0x1827DF160")]
		public void Render(Act12SideData.ActZoneClass filterClass)
		{
		}

		// Token: 0x0602C009 RID: 180233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C009")]
		[Address(RVA = "0x27DF050", Offset = "0x27DDC50", VA = "0x1827DF050")]
		public void OnFilterClick()
		{
		}

		// Token: 0x0602C00A RID: 180234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C00A")]
		[Address(RVA = "0x27DF260", Offset = "0x27DDE60", VA = "0x1827DF260")]
		public Act12sideMissionFilterItemView()
		{
		}

		// Token: 0x0403FBF9 RID: 261113
		[Token(Token = "0x403FBF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act12SideData.ActZoneClass _zoneClass;

		// Token: 0x0403FBFA RID: 261114
		[Token(Token = "0x403FBFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgSelected;

		// Token: 0x0403FBFB RID: 261115
		[Token(Token = "0x403FBFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textClass;

		// Token: 0x0403FBFC RID: 261116
		[Token(Token = "0x403FBFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0403FBFD RID: 261117
		[Token(Token = "0x403FBFD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorSelected;

		// Token: 0x0403FBFF RID: 261119
		[Token(Token = "0x403FBFF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onFilterSelected;

		// Token: 0x0403FC00 RID: 261120
		[Token(Token = "0x403FC00")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onFilterSelected;

		// Token: 0x0403FC01 RID: 261121
		[Token(Token = "0x403FC01")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403FC02 RID: 261122
		[Token(Token = "0x403FC02")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFilterClick;

		// Token: 0x0403FC03 RID: 261123
		[Token(Token = "0x403FC03")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
