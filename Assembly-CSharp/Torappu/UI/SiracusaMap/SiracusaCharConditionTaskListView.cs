using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F0F RID: 16143
	[Token(Token = "0x2003F0F")]
	public class SiracusaCharConditionTaskListView : SiracusaCharTaskListView
	{
		// Token: 0x06019115 RID: 102677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019115")]
		[Address(RVA = "0x11B1650", Offset = "0x11B0250", VA = "0x1811B1650", Slot = "4")]
		public override void Render(SiracusaCharTaskRingModel taskRingModel)
		{
		}

		// Token: 0x06019116 RID: 102678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019116")]
		[Address(RVA = "0x11B17A0", Offset = "0x11B03A0", VA = "0x1811B17A0")]
		public SiracusaCharConditionTaskListView()
		{
		}

		// Token: 0x06019117 RID: 102679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019117")]
		[Address(RVA = "0x11B1790", Offset = "0x11B0390", VA = "0x1811B1790")]
		private void <>xLuaBaseProxy_Render(SiracusaCharTaskRingModel P0)
		{
		}

		// Token: 0x0401F01F RID: 127007
		[Token(Token = "0x401F01F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _imgLogicType;

		// Token: 0x0401F020 RID: 127008
		[Token(Token = "0x401F020")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasObject _statusAtlas;

		// Token: 0x0401F021 RID: 127009
		[Token(Token = "0x401F021")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _iconOrName;

		// Token: 0x0401F022 RID: 127010
		[Token(Token = "0x401F022")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _iconAndName;

		// Token: 0x0401F023 RID: 127011
		[Token(Token = "0x401F023")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F024 RID: 127012
		[Token(Token = "0x401F024")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
