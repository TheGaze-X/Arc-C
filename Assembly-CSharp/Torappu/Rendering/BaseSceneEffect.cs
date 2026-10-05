using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002041 RID: 8257
	[Token(Token = "0x2002041")]
	public abstract class BaseSceneEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x0600CB76 RID: 52086 RVA: 0x00049938 File Offset: 0x00047B38
		// (set) Token: 0x0600CB77 RID: 52087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001820")]
		private protected bool inited
		{
			[Token(Token = "0x600CB76")]
			[Address(RVA = "0x34BE900", Offset = "0x34BD500", VA = "0x1834BE900")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600CB77")]
			[Address(RVA = "0x34BE9C0", Offset = "0x34BD5C0", VA = "0x1834BE9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600CB78 RID: 52088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB78")]
		[Address(RVA = "0x34BE650", Offset = "0x34BD250", VA = "0x1834BE650", Slot = "4")]
		public virtual void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CB79 RID: 52089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB79")]
		[Address(RVA = "0x34BE4B0", Offset = "0x34BD0B0", VA = "0x1834BE4B0")]
		public void Init()
		{
		}

		// Token: 0x0600CB7A RID: 52090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB7A")]
		[Address(RVA = "0x34BE570", Offset = "0x34BD170", VA = "0x1834BE570")]
		public void LateInit()
		{
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB7B")]
		[Address(RVA = "0x34BE2D0", Offset = "0x34BCED0", VA = "0x1834BE2D0")]
		public void Finish()
		{
		}

		// Token: 0x0600CB7C RID: 52092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB7C")]
		[Address(RVA = "0x34BE730", Offset = "0x34BD330", VA = "0x1834BE730", Slot = "5")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0600CB7D RID: 52093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB7D")]
		[Address(RVA = "0x34BE790", Offset = "0x34BD390", VA = "0x1834BE790", Slot = "6")]
		protected virtual void OnLateInit()
		{
		}

		// Token: 0x0600CB7E RID: 52094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB7E")]
		[Address(RVA = "0x34BE6D0", Offset = "0x34BD2D0", VA = "0x1834BE6D0", Slot = "7")]
		protected virtual void OnFinish()
		{
		}

		// Token: 0x0600CB7F RID: 52095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB7F")]
		[Address(RVA = "0x34BE5F0", Offset = "0x34BD1F0", VA = "0x1834BE5F0", Slot = "8")]
		public virtual void Merge(BaseSceneEffect another)
		{
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x0600CB80 RID: 52096 RVA: 0x00049950 File Offset: 0x00047B50
		[Token(Token = "0x17001821")]
		public virtual BaseSceneEffect.MergeType mergeType
		{
			[Token(Token = "0x600CB80")]
			[Address(RVA = "0x34BE960", Offset = "0x34BD560", VA = "0x1834BE960", Slot = "9")]
			get
			{
				return BaseSceneEffect.MergeType.DESTROY_COMPONENT;
			}
		}

		// Token: 0x0600CB81 RID: 52097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CB81")]
		[Address(RVA = "0x34BE3F0", Offset = "0x34BCFF0", VA = "0x1834BE3F0", Slot = "10")]
		public virtual Animation GetSceneWaterAnimator()
		{
			return null;
		}

		// Token: 0x0600CB82 RID: 52098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CB82")]
		[Address(RVA = "0x34BE390", Offset = "0x34BCF90", VA = "0x1834BE390", Slot = "11")]
		public virtual Shader GetReplaceSpineShader()
		{
			return null;
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x00049968 File Offset: 0x00047B68
		[Token(Token = "0x600CB83")]
		[Address(RVA = "0x34BE7F0", Offset = "0x34BD3F0", VA = "0x1834BE7F0", Slot = "12")]
		public virtual bool TryGetTileReplaceSpineShader(out Shader replaceShader, out IList<Vector2> tilePosList)
		{
			return default(bool);
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CB84")]
		[Address(RVA = "0x34BE450", Offset = "0x34BD050", VA = "0x1834BE450", Slot = "13")]
		public virtual string GetSpineOnTileFlagName()
		{
			return null;
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB85")]
		[Address(RVA = "0x34BE8A0", Offset = "0x34BD4A0", VA = "0x1834BE8A0")]
		protected BaseSceneEffect()
		{
		}

		// Token: 0x0400D5B0 RID: 54704
		[Token(Token = "0x400D5B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inited;

		// Token: 0x0400D5B1 RID: 54705
		[Token(Token = "0x400D5B1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_inited;

		// Token: 0x0400D5B2 RID: 54706
		[Token(Token = "0x400D5B2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D5B3 RID: 54707
		[Token(Token = "0x400D5B3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400D5B4 RID: 54708
		[Token(Token = "0x400D5B4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LateInit;

		// Token: 0x0400D5B5 RID: 54709
		[Token(Token = "0x400D5B5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Finish;

		// Token: 0x0400D5B6 RID: 54710
		[Token(Token = "0x400D5B6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D5B7 RID: 54711
		[Token(Token = "0x400D5B7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLateInit;

		// Token: 0x0400D5B8 RID: 54712
		[Token(Token = "0x400D5B8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D5B9 RID: 54713
		[Token(Token = "0x400D5B9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Merge;

		// Token: 0x0400D5BA RID: 54714
		[Token(Token = "0x400D5BA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_mergeType;

		// Token: 0x0400D5BB RID: 54715
		[Token(Token = "0x400D5BB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetSceneWaterAnimator;

		// Token: 0x0400D5BC RID: 54716
		[Token(Token = "0x400D5BC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetReplaceSpineShader;

		// Token: 0x0400D5BD RID: 54717
		[Token(Token = "0x400D5BD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryGetTileReplaceSpineShader;

		// Token: 0x0400D5BE RID: 54718
		[Token(Token = "0x400D5BE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetSpineOnTileFlagName;

		// Token: 0x0400D5BF RID: 54719
		[Token(Token = "0x400D5BF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002042 RID: 8258
		[Token(Token = "0x2002042")]
		public enum MergeType
		{
			// Token: 0x0400D5C1 RID: 54721
			[Token(Token = "0x400D5C1")]
			DESTROY_COMPONENT,
			// Token: 0x0400D5C2 RID: 54722
			[Token(Token = "0x400D5C2")]
			DESTROY_GAMEOBJECT
		}
	}
}
