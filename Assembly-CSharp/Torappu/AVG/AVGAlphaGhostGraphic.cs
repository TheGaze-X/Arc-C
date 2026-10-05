using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EEC RID: 7916
	[Token(Token = "0x2001EEC")]
	public class AVGAlphaGhostGraphic : Image, IHotfixable
	{
		// Token: 0x0600C479 RID: 50297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C479")]
		[Address(RVA = "0x341D480", Offset = "0x341C080", VA = "0x18341D480")]
		private static void _SetMaterialParams(Material mat, AVGAlphaGhostGraphic self)
		{
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47A")]
		[Address(RVA = "0x341C960", Offset = "0x341B560", VA = "0x18341C960")]
		public void SetTextures(PostDisplayItem.Textures textures)
		{
		}

		// Token: 0x0600C47B RID: 50299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47B")]
		[Address(RVA = "0x341C710", Offset = "0x341B310", VA = "0x18341C710")]
		public void SetMaterial(Material material)
		{
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47C")]
		[Address(RVA = "0x341D2E0", Offset = "0x341BEE0", VA = "0x18341D2E0")]
		private void _SetMaterialImpl(Material baseOrCurMaterial)
		{
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47D")]
		[Address(RVA = "0x341D120", Offset = "0x341BD20", VA = "0x18341D120")]
		private void _SetHostImage(CanvasGroup canvasGroup, Image host)
		{
		}

		// Token: 0x0600C47E RID: 50302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47E")]
		[Address(RVA = "0x341CFC0", Offset = "0x341BBC0", VA = "0x18341CFC0")]
		private void _SetBaseAlpha(float alpha)
		{
		}

		// Token: 0x0600C47F RID: 50303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C47F")]
		[Address(RVA = "0x341C5E0", Offset = "0x341B1E0", VA = "0x18341C5E0")]
		protected new void OnDestroy()
		{
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x0600C480 RID: 50304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001770")]
		public override Texture mainTexture
		{
			[Token(Token = "0x600C480")]
			[Address(RVA = "0x341D790", Offset = "0x341C390", VA = "0x18341D790", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001771 RID: 6001
		// (get) Token: 0x0600C481 RID: 50305 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C482 RID: 50306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001771")]
		public override Material material
		{
			[Token(Token = "0x600C481")]
			[Address(RVA = "0x341D8A0", Offset = "0x341C4A0", VA = "0x18341D8A0", Slot = "34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C482")]
			[Address(RVA = "0x341D900", Offset = "0x341C500", VA = "0x18341D900", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x0600C483 RID: 50307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001772")]
		public override Material materialForRendering
		{
			[Token(Token = "0x600C483")]
			[Address(RVA = "0x341D7F0", Offset = "0x341C3F0", VA = "0x18341D7F0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C484 RID: 50308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C484")]
		[Address(RVA = "0x341CE70", Offset = "0x341BA70", VA = "0x18341CE70", Slot = "42")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x0600C485 RID: 50309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C485")]
		[Address(RVA = "0x341D610", Offset = "0x341C210", VA = "0x18341D610")]
		public AVGAlphaGhostGraphic()
		{
		}

		// Token: 0x0600C486 RID: 50310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C486")]
		[Address(RVA = "0x341CE50", Offset = "0x341BA50", VA = "0x18341CE50")]
		private Texture <>xLuaBaseProxy_get_mainTexture()
		{
			return null;
		}

		// Token: 0x0600C487 RID: 50311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C487")]
		[Address(RVA = "0x341CE60", Offset = "0x341BA60", VA = "0x18341CE60")]
		private Material <>xLuaBaseProxy_get_material()
		{
			return null;
		}

		// Token: 0x0600C488 RID: 50312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C488")]
		[Address(RVA = "0xDEFB50", Offset = "0xDEE750", VA = "0x180DEFB50")]
		private void <>xLuaBaseProxy_set_material(Material P0)
		{
		}

		// Token: 0x0600C489 RID: 50313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C489")]
		[Address(RVA = "0xF02F40", Offset = "0xF01B40", VA = "0x180F02F40")]
		private Material <>xLuaBaseProxy_get_materialForRendering()
		{
			return null;
		}

		// Token: 0x0600C48A RID: 50314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C48A")]
		[Address(RVA = "0x341CE40", Offset = "0x341BA40", VA = "0x18341CE40")]
		private void <>xLuaBaseProxy_UpdateMaterial()
		{
		}

		// Token: 0x0400C8F3 RID: 51443
		[Token(Token = "0x400C8F3")]
		[FieldOffset(Offset = "0x190")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400C8F4 RID: 51444
		[Token(Token = "0x400C8F4")]
		[FieldOffset(Offset = "0x198")]
		private Texture m_mainTex;

		// Token: 0x0400C8F5 RID: 51445
		[Token(Token = "0x400C8F5")]
		[FieldOffset(Offset = "0x1A0")]
		private bool m_isAlaphTex;

		// Token: 0x0400C8F6 RID: 51446
		[Token(Token = "0x400C8F6")]
		[FieldOffset(Offset = "0x1A4")]
		private int m_baseMatGUID;

		// Token: 0x0400C8F7 RID: 51447
		[Token(Token = "0x400C8F7")]
		[FieldOffset(Offset = "0x1A8")]
		private Material m_material;

		// Token: 0x0400C8F8 RID: 51448
		[Token(Token = "0x400C8F8")]
		[FieldOffset(Offset = "0x1B0")]
		private Texture m_dynTex;

		// Token: 0x0400C8F9 RID: 51449
		[Token(Token = "0x400C8F9")]
		[FieldOffset(Offset = "0x1B8")]
		private Vector2 m_dynScale;

		// Token: 0x0400C8FA RID: 51450
		[Token(Token = "0x400C8FA")]
		[FieldOffset(Offset = "0x1C0")]
		private Vector2 m_dynOffset;

		// Token: 0x0400C8FB RID: 51451
		[Token(Token = "0x400C8FB")]
		[FieldOffset(Offset = "0x1C8")]
		private AVGAlphaGhostGraphic.AlphaTracker m_alphaTracker;

		// Token: 0x0400C8FC RID: 51452
		[Token(Token = "0x400C8FC")]
		[FieldOffset(Offset = "0x1D0")]
		private LatchUtils.SetWhenBind<Material, AVGAlphaGhostGraphic> m_setMatProps;

		// Token: 0x0400C8FD RID: 51453
		[Token(Token = "0x400C8FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetMaterialParams;

		// Token: 0x0400C8FE RID: 51454
		[Token(Token = "0x400C8FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetTextures;

		// Token: 0x0400C8FF RID: 51455
		[Token(Token = "0x400C8FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetMaterial;

		// Token: 0x0400C900 RID: 51456
		[Token(Token = "0x400C900")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetMaterialImpl;

		// Token: 0x0400C901 RID: 51457
		[Token(Token = "0x400C901")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetHostImage;

		// Token: 0x0400C902 RID: 51458
		[Token(Token = "0x400C902")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetBaseAlpha;

		// Token: 0x0400C903 RID: 51459
		[Token(Token = "0x400C903")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400C904 RID: 51460
		[Token(Token = "0x400C904")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_mainTexture;

		// Token: 0x0400C905 RID: 51461
		[Token(Token = "0x400C905")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_material;

		// Token: 0x0400C906 RID: 51462
		[Token(Token = "0x400C906")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_material;

		// Token: 0x0400C907 RID: 51463
		[Token(Token = "0x400C907")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_materialForRendering;

		// Token: 0x0400C908 RID: 51464
		[Token(Token = "0x400C908")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateMaterial;

		// Token: 0x0400C909 RID: 51465
		[Token(Token = "0x400C909")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EED RID: 7917
		[Token(Token = "0x2001EED")]
		public abstract class BaseItem : PostDisplayItem
		{
			// Token: 0x0600C48B RID: 50315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C48B")]
			[Address(RVA = "0x342E0D0", Offset = "0x342CCD0", VA = "0x18342E0D0")]
			private void _SetTexturesToGraphic(AVGAlphaGhostGraphic graphic, PostDisplayItem.Textures textures)
			{
			}

			// Token: 0x0600C48C RID: 50316 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C48C")]
			[Address(RVA = "0x342DFF0", Offset = "0x342CBF0", VA = "0x18342DFF0")]
			private LatchUtils.SetWhenBind<AVGAlphaGhostGraphic, PostDisplayItem.Textures> _EnsureSetTextures()
			{
				return null;
			}

			// Token: 0x0600C48D RID: 50317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C48D")]
			[Address(RVA = "0x342D7E0", Offset = "0x342C3E0", VA = "0x18342D7E0")]
			public void SetAlpha(float amount)
			{
			}

			// Token: 0x0600C48E RID: 50318
			[Token(Token = "0x600C48E")]
			protected abstract bool EnableAlphaRim();

			// Token: 0x0600C48F RID: 50319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C48F")]
			[Address(RVA = "0x342D6D0", Offset = "0x342C2D0", VA = "0x18342D6D0", Slot = "6")]
			protected override void OnInit()
			{
			}

			// Token: 0x0600C490 RID: 50320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C490")]
			[Address(RVA = "0x342D610", Offset = "0x342C210", VA = "0x18342D610", Slot = "5")]
			protected override void OnDispose()
			{
			}

			// Token: 0x0600C491 RID: 50321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C491")]
			[Address(RVA = "0x342D760", Offset = "0x342C360", VA = "0x18342D760", Slot = "7")]
			protected override void OnTexturesChanged(PostDisplayItem.Textures texs)
			{
			}

			// Token: 0x0600C492 RID: 50322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C492")]
			[Address(RVA = "0x342DA60", Offset = "0x342C660", VA = "0x18342DA60")]
			private AVGAlphaGhostGraphic _CreateGhostGraphic(RectTransform parent)
			{
				return null;
			}

			// Token: 0x0600C493 RID: 50323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C493")]
			[Address(RVA = "0x342E120", Offset = "0x342CD20", VA = "0x18342E120")]
			protected BaseItem()
			{
			}

			// Token: 0x0400C90A RID: 51466
			[Token(Token = "0x400C90A")]
			[FieldOffset(Offset = "0x40")]
			protected AVGAlphaGhostGraphic ghost;

			// Token: 0x0400C90B RID: 51467
			[Token(Token = "0x400C90B")]
			[FieldOffset(Offset = "0x48")]
			private RectTransform m_baseTransform;

			// Token: 0x0400C90C RID: 51468
			[Token(Token = "0x400C90C")]
			[FieldOffset(Offset = "0x50")]
			private LatchUtils.SetWhenBind<AVGAlphaGhostGraphic, PostDisplayItem.Textures> m_setTextures;
		}

		// Token: 0x02001EEE RID: 7918
		[Token(Token = "0x2001EEE")]
		public class SolidItem : AVGAlphaGhostGraphic.BaseItem
		{
			// Token: 0x0600C494 RID: 50324 RVA: 0x000480F0 File Offset: 0x000462F0
			[Token(Token = "0x600C494")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			protected override bool EnableAlphaRim()
			{
				return default(bool);
			}

			// Token: 0x0600C495 RID: 50325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C495")]
			[Address(RVA = "0x34326C0", Offset = "0x34312C0", VA = "0x1834326C0")]
			public SolidItem()
			{
			}
		}

		// Token: 0x02001EEF RID: 7919
		[Token(Token = "0x2001EEF")]
		public class SoftItem : AVGAlphaGhostGraphic.BaseItem
		{
			// Token: 0x0600C496 RID: 50326 RVA: 0x00048108 File Offset: 0x00046308
			[Token(Token = "0x600C496")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
			protected override bool EnableAlphaRim()
			{
				return default(bool);
			}

			// Token: 0x0600C497 RID: 50327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C497")]
			[Address(RVA = "0x34326C0", Offset = "0x34312C0", VA = "0x1834326C0")]
			public SoftItem()
			{
			}
		}

		// Token: 0x02001EF0 RID: 7920
		[Token(Token = "0x2001EF0")]
		private class AlphaTracker : IDisposable, ITimeWatcher
		{
			// Token: 0x0600C498 RID: 50328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C498")]
			[Address(RVA = "0x342D560", Offset = "0x342C160", VA = "0x18342D560")]
			public AlphaTracker(CanvasGroup alphaHandler, Graphic trackTarget)
			{
			}

			// Token: 0x0600C499 RID: 50329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C499")]
			[Address(RVA = "0x342D1F0", Offset = "0x342BDF0", VA = "0x18342D1F0")]
			public void SetBaseAlpha(float baseAlpha)
			{
			}

			// Token: 0x0600C49A RID: 50330 RVA: 0x00048120 File Offset: 0x00046320
			[Token(Token = "0x600C49A")]
			[Address(RVA = "0x342D490", Offset = "0x342C090", VA = "0x18342D490")]
			private float _GetTrackTargetAlpha()
			{
				return 0f;
			}

			// Token: 0x0600C49B RID: 50331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C49B")]
			[Address(RVA = "0x342D470", Offset = "0x342C070", VA = "0x18342D470")]
			private void _EnableTrack(bool enable)
			{
			}

			// Token: 0x0600C49C RID: 50332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C49C")]
			[Address(RVA = "0x342D2F0", Offset = "0x342BEF0", VA = "0x18342D2F0", Slot = "5")]
			public void UpdateTime(float delta)
			{
			}

			// Token: 0x0600C49D RID: 50333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C49D")]
			[Address(RVA = "0x342D1A0", Offset = "0x342BDA0", VA = "0x18342D1A0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0400C90D RID: 51469
			[Token(Token = "0x400C90D")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isTracking;

			// Token: 0x0400C90E RID: 51470
			[Token(Token = "0x400C90E")]
			[FieldOffset(Offset = "0x18")]
			private CanvasGroup m_alphaHandler;

			// Token: 0x0400C90F RID: 51471
			[Token(Token = "0x400C90F")]
			[FieldOffset(Offset = "0x20")]
			private Graphic m_trackTarget;

			// Token: 0x0400C910 RID: 51472
			[Token(Token = "0x400C910")]
			[FieldOffset(Offset = "0x28")]
			private float m_baseAlpha;
		}
	}
}
