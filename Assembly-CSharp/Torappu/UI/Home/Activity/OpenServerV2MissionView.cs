using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C8D RID: 19597
	[Token(Token = "0x2004C8D")]
	public class OpenServerV2MissionView : OpenServerV2FuncAbstractView
	{
		// Token: 0x0601D605 RID: 120325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D605")]
		[Address(RVA = "0x16F1510", Offset = "0x16F0110", VA = "0x1816F1510", Slot = "4")]
		public override void Render(OpenServerV2MainViewModel viewModel, bool isInit)
		{
		}

		// Token: 0x0601D606 RID: 120326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D606")]
		[Address(RVA = "0x16F1740", Offset = "0x16F0340", VA = "0x1816F1740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D607 RID: 120327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D607")]
		[Address(RVA = "0x16F1860", Offset = "0x16F0460", VA = "0x1816F1860")]
		public OpenServerV2MissionView()
		{
		}

		// Token: 0x04026ABD RID: 158397
		[Token(Token = "0x4026ABD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x04026ABE RID: 158398
		[Token(Token = "0x4026ABE")]
		[FieldOffset(Offset = "0x20")]
		private OpenServerV2MissionViewModel m_viewModel;

		// Token: 0x04026ABF RID: 158399
		[Token(Token = "0x4026ABF")]
		[FieldOffset(Offset = "0x28")]
		private OpenServerV2MissionView.MissionAdapter m_adapter;

		// Token: 0x04026AC0 RID: 158400
		[Token(Token = "0x4026AC0")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04026AC1 RID: 158401
		[Token(Token = "0x4026AC1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026AC2 RID: 158402
		[Token(Token = "0x4026AC2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026AC3 RID: 158403
		[Token(Token = "0x4026AC3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C8E RID: 19598
		[Token(Token = "0x2004C8E")]
		private class MissionAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D608 RID: 120328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D608")]
			[Address(RVA = "0x16EA070", Offset = "0x16E8C70", VA = "0x1816EA070")]
			public MissionAdapter(OpenServerV2MissionView closure)
			{
			}

			// Token: 0x170044EC RID: 17644
			// (get) Token: 0x0601D609 RID: 120329 RVA: 0x000AB498 File Offset: 0x000A9698
			[Token(Token = "0x170044EC")]
			public override int count
			{
				[Token(Token = "0x601D609")]
				[Address(RVA = "0x16EA0F0", Offset = "0x16E8CF0", VA = "0x1816EA0F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D60A RID: 120330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D60A")]
			[Address(RVA = "0x16E9EC0", Offset = "0x16E8AC0", VA = "0x1816E9EC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026AC4 RID: 158404
			[Token(Token = "0x4026AC4")]
			[FieldOffset(Offset = "0x20")]
			private OpenServerV2MissionView m_closure;

			// Token: 0x04026AC5 RID: 158405
			[Token(Token = "0x4026AC5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026AC6 RID: 158406
			[Token(Token = "0x4026AC6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026AC7 RID: 158407
			[Token(Token = "0x4026AC7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
