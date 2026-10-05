using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076B2 RID: 30386
	[Token(Token = "0x20076B2")]
	public class Act1VHalfIdleActivityEntryTutorialHandler : TemplateActivityEntryTutorialHandler
	{
		// Token: 0x0602ABD3 RID: 175059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABD3")]
		[Address(RVA = "0x2681190", Offset = "0x267FD90", VA = "0x182681190", Slot = "4")]
		public override void RegisterTutorialGO()
		{
		}

		// Token: 0x0602ABD4 RID: 175060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ABD4")]
		[Address(RVA = "0x26812D0", Offset = "0x267FED0", VA = "0x1826812D0")]
		public Act1VHalfIdleActivityEntryTutorialHandler()
		{
		}

		// Token: 0x0403D938 RID: 252216
		[Token(Token = "0x403D938")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnStage;

		// Token: 0x0403D939 RID: 252217
		[Token(Token = "0x403D939")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _btnDepot;

		// Token: 0x0403D93A RID: 252218
		[Token(Token = "0x403D93A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _btnTechTree;

		// Token: 0x0403D93B RID: 252219
		[Token(Token = "0x403D93B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnHarvest;

		// Token: 0x0403D93C RID: 252220
		[Token(Token = "0x403D93C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403D93D RID: 252221
		[Token(Token = "0x403D93D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
