using System;
using Il2CppDummyDll;
using Spine.Unity;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x0200719E RID: 29086
	[Token(Token = "0x200719E")]
	public class Act7FunSpineDisplaySpineHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029447 RID: 169031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029447")]
		[Address(RVA = "0x24BDF90", Offset = "0x24BCB90", VA = "0x1824BDF90")]
		public void Render(Act7FunSpineDisplayItemModel itemModel)
		{
		}

		// Token: 0x06029448 RID: 169032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029448")]
		[Address(RVA = "0x24BDF30", Offset = "0x24BCB30", VA = "0x1824BDF30")]
		public void Clear()
		{
		}

		// Token: 0x06029449 RID: 169033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029449")]
		[Address(RVA = "0x24BE010", Offset = "0x24BCC10", VA = "0x1824BE010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602944A RID: 169034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602944A")]
		[Address(RVA = "0x24BE090", Offset = "0x24BCC90", VA = "0x1824BE090")]
		private void _LoadSpineImpl(Act7FunSpineDisplayItemModel itemModel)
		{
		}

		// Token: 0x0602944B RID: 169035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602944B")]
		[Address(RVA = "0x24BE1E0", Offset = "0x24BCDE0", VA = "0x1824BE1E0")]
		public Act7FunSpineDisplaySpineHolder()
		{
		}

		// Token: 0x0403AF03 RID: 241411
		[Token(Token = "0x403AF03")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UISpineHolder _spineHolder;

		// Token: 0x0403AF04 RID: 241412
		[Token(Token = "0x403AF04")]
		[FieldOffset(Offset = "0x20")]
		private Act7FunSpineDisplaySpineHolder.Act7FunSpineAdapter m_spineImpl;

		// Token: 0x0403AF05 RID: 241413
		[Token(Token = "0x403AF05")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x0403AF06 RID: 241414
		[Token(Token = "0x403AF06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AF07 RID: 241415
		[Token(Token = "0x403AF07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0403AF08 RID: 241416
		[Token(Token = "0x403AF08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403AF09 RID: 241417
		[Token(Token = "0x403AF09")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadSpineImpl;

		// Token: 0x0403AF0A RID: 241418
		[Token(Token = "0x403AF0A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200719F RID: 29087
		[Token(Token = "0x200719F")]
		public class Act7FunSpineLoader : UISpineHolder.CustomSpineLoader, IHotfixable
		{
			// Token: 0x0602944C RID: 169036 RVA: 0x000D4EF8 File Offset: 0x000D30F8
			[Token(Token = "0x602944C")]
			[Address(RVA = "0x24BE4D0", Offset = "0x24BD0D0", VA = "0x1824BE4D0", Slot = "4")]
			protected override bool LoadImplement()
			{
				return default(bool);
			}

			// Token: 0x0602944D RID: 169037 RVA: 0x000D4F10 File Offset: 0x000D3110
			[Token(Token = "0x602944D")]
			[Address(RVA = "0x24BE470", Offset = "0x24BD070", VA = "0x1824BE470", Slot = "5")]
			public override float GetSpineScale()
			{
				return 0f;
			}

			// Token: 0x0602944E RID: 169038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602944E")]
			[Address(RVA = "0x24BE350", Offset = "0x24BCF50", VA = "0x1824BE350", Slot = "6")]
			public override UnityEngine.Object GetAsset()
			{
				return null;
			}

			// Token: 0x0602944F RID: 169039 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602944F")]
			[Address(RVA = "0x24BE3B0", Offset = "0x24BCFB0", VA = "0x1824BE3B0", Slot = "7")]
			public override SkeletonAnimation GetSkeletonAnim()
			{
				return null;
			}

			// Token: 0x06029450 RID: 169040 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029450")]
			[Address(RVA = "0x24BE410", Offset = "0x24BD010", VA = "0x1824BE410", Slot = "8")]
			public override SkeletonGraphic GetSkeletonGraphic()
			{
				return null;
			}

			// Token: 0x06029451 RID: 169041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029451")]
			[Address(RVA = "0x24BE630", Offset = "0x24BD230", VA = "0x1824BE630")]
			public Act7FunSpineLoader()
			{
			}

			// Token: 0x0403AF0B RID: 241419
			[Token(Token = "0x403AF0B")]
			[FieldOffset(Offset = "0x28")]
			private SkeletonGraphic m_asset;

			// Token: 0x0403AF0C RID: 241420
			[Token(Token = "0x403AF0C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadImplement;

			// Token: 0x0403AF0D RID: 241421
			[Token(Token = "0x403AF0D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetSpineScale;

			// Token: 0x0403AF0E RID: 241422
			[Token(Token = "0x403AF0E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetAsset;

			// Token: 0x0403AF0F RID: 241423
			[Token(Token = "0x403AF0F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSkeletonAnim;

			// Token: 0x0403AF10 RID: 241424
			[Token(Token = "0x403AF10")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetSkeletonGraphic;

			// Token: 0x0403AF11 RID: 241425
			[Token(Token = "0x403AF11")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020071A0 RID: 29088
		[Token(Token = "0x20071A0")]
		public class Act7FunSpineAdapter : UISpineHolder.Adapter, IHotfixable
		{
			// Token: 0x06029452 RID: 169042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029452")]
			[Address(RVA = "0x24BD6E0", Offset = "0x24BC2E0", VA = "0x1824BD6E0")]
			public void UpdateModel(Act7FunSpineDisplayItemModel itemModel)
			{
			}

			// Token: 0x06029453 RID: 169043 RVA: 0x000D4F28 File Offset: 0x000D3128
			[Token(Token = "0x6029453")]
			[Address(RVA = "0x24BD470", Offset = "0x24BC070", VA = "0x1824BD470", Slot = "4")]
			public override UISpineHolder.SpineID GetSpineID()
			{
				return default(UISpineHolder.SpineID);
			}

			// Token: 0x06029454 RID: 169044 RVA: 0x000D4F40 File Offset: 0x000D3140
			[Token(Token = "0x6029454")]
			[Address(RVA = "0x24BD580", Offset = "0x24BC180", VA = "0x1824BD580", Slot = "5")]
			public override Misc.TRS GetTransformParam()
			{
				return default(Misc.TRS);
			}

			// Token: 0x06029455 RID: 169045 RVA: 0x000D4F58 File Offset: 0x000D3158
			[Token(Token = "0x6029455")]
			[Address(RVA = "0x24BD3A0", Offset = "0x24BBFA0", VA = "0x1824BD3A0", Slot = "6")]
			public override UISpineHolder.SpineAnimParam GetAnimParam()
			{
				return default(UISpineHolder.SpineAnimParam);
			}

			// Token: 0x06029456 RID: 169046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029456")]
			[Address(RVA = "0x24BD520", Offset = "0x24BC120", VA = "0x1824BD520", Slot = "7")]
			public override UISpineHolder.CustomSpineLoader GetSpineLoader()
			{
				return null;
			}

			// Token: 0x06029457 RID: 169047 RVA: 0x000D4F70 File Offset: 0x000D3170
			[Token(Token = "0x6029457")]
			[Address(RVA = "0x24BD330", Offset = "0x24BBF30", VA = "0x1824BD330", Slot = "8")]
			public override bool EnableReverseMode(string animName)
			{
				return default(bool);
			}

			// Token: 0x06029458 RID: 169048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029458")]
			[Address(RVA = "0x24BD760", Offset = "0x24BC360", VA = "0x1824BD760")]
			public Act7FunSpineAdapter()
			{
			}

			// Token: 0x06029459 RID: 169049 RVA: 0x000D4F88 File Offset: 0x000D3188
			[Token(Token = "0x6029459")]
			[Address(RVA = "0xF3EC30", Offset = "0xF3D830", VA = "0x180F3EC30")]
			private Misc.TRS <>xLuaBaseProxy_GetTransformParam()
			{
				return default(Misc.TRS);
			}

			// Token: 0x0602945A RID: 169050 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602945A")]
			[Address(RVA = "0x24BD6D0", Offset = "0x24BC2D0", VA = "0x1824BD6D0")]
			private UISpineHolder.CustomSpineLoader <>xLuaBaseProxy_GetSpineLoader()
			{
				return null;
			}

			// Token: 0x0602945B RID: 169051 RVA: 0x000D4FA0 File Offset: 0x000D31A0
			[Token(Token = "0x602945B")]
			[Address(RVA = "0xF3F0B0", Offset = "0xF3DCB0", VA = "0x180F3F0B0")]
			private bool <>xLuaBaseProxy_EnableReverseMode(string P0)
			{
				return default(bool);
			}

			// Token: 0x0403AF12 RID: 241426
			[Token(Token = "0x403AF12")]
			[FieldOffset(Offset = "0x48")]
			private Act7FunSpineDisplayItemModel m_itemModel;

			// Token: 0x0403AF13 RID: 241427
			[Token(Token = "0x403AF13")]
			[FieldOffset(Offset = "0x50")]
			private Act7FunSpineDisplaySpineHolder.Act7FunSpineLoader m_loader;

			// Token: 0x0403AF14 RID: 241428
			[Token(Token = "0x403AF14")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateModel;

			// Token: 0x0403AF15 RID: 241429
			[Token(Token = "0x403AF15")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetSpineID;

			// Token: 0x0403AF16 RID: 241430
			[Token(Token = "0x403AF16")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTransformParam;

			// Token: 0x0403AF17 RID: 241431
			[Token(Token = "0x403AF17")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetAnimParam;

			// Token: 0x0403AF18 RID: 241432
			[Token(Token = "0x403AF18")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetSpineLoader;

			// Token: 0x0403AF19 RID: 241433
			[Token(Token = "0x403AF19")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_EnableReverseMode;

			// Token: 0x0403AF1A RID: 241434
			[Token(Token = "0x403AF1A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
