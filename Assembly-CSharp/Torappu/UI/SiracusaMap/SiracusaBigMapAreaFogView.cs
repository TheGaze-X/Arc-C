using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F74 RID: 16244
	[Token(Token = "0x2003F74")]
	public class SiracusaBigMapAreaFogView : SiracusaMapAreaFogViewBase
	{
		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x06019347 RID: 103239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019348 RID: 103240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C33")]
		public Action fogClickAction
		{
			[Token(Token = "0x6019347")]
			[Address(RVA = "0x11E2020", Offset = "0x11E0C20", VA = "0x1811E2020")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6019348")]
			[Address(RVA = "0x11E2080", Offset = "0x11E0C80", VA = "0x1811E2080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06019349 RID: 103241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019349")]
		[Address(RVA = "0x11E1D90", Offset = "0x11E0990", VA = "0x1811E1D90", Slot = "4")]
		public override void Render(SiracusaData.AreaData areaData, bool isShow)
		{
		}

		// Token: 0x0601934A RID: 103242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601934A")]
		[Address(RVA = "0x11E1C80", Offset = "0x11E0880", VA = "0x1811E1C80")]
		public void EventOnFogClicked()
		{
		}

		// Token: 0x0601934B RID: 103243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601934B")]
		[Address(RVA = "0x11E1F80", Offset = "0x11E0B80", VA = "0x1811E1F80")]
		public SiracusaBigMapAreaFogView()
		{
		}

		// Token: 0x0401F408 RID: 128008
		[Token(Token = "0x401F408")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIDynImage _imgAreaIcon;

		// Token: 0x0401F409 RID: 128009
		[Token(Token = "0x401F409")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtAreaName;

		// Token: 0x0401F40A RID: 128010
		[Token(Token = "0x401F40A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtAreaItalyName;

		// Token: 0x0401F40B RID: 128011
		[Token(Token = "0x401F40B")]
		[FieldOffset(Offset = "0x50")]
		private string m_areaId;

		// Token: 0x0401F40D RID: 128013
		[Token(Token = "0x401F40D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fogClickAction;

		// Token: 0x0401F40E RID: 128014
		[Token(Token = "0x401F40E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_fogClickAction;

		// Token: 0x0401F40F RID: 128015
		[Token(Token = "0x401F40F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F410 RID: 128016
		[Token(Token = "0x401F410")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFogClicked;

		// Token: 0x0401F411 RID: 128017
		[Token(Token = "0x401F411")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
