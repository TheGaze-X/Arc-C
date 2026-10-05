using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SoftMasking
{
	// Token: 0x02000447 RID: 1095
	[Token(Token = "0x2000447")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	public class SoftMaskable : UIBehaviour, IMaterialModifier
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x0002C5E0 File Offset: 0x0002A7E0
		// (set) Token: 0x060049F4 RID: 18932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000179")]
		public bool shaderIsNotSupported
		{
			[Token(Token = "0x60049F3")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60049F4")]
			[Address(RVA = "0x1694F60", Offset = "0x1693B60", VA = "0x181694F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
		[Token(Token = "0x1700017A")]
		public bool isMaskingEnabled
		{
			[Token(Token = "0x60049F5")]
			[Address(RVA = "0x1694CC0", Offset = "0x16938C0", VA = "0x181694CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060049F7 RID: 18935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017B")]
		public ISoftMask mask
		{
			[Token(Token = "0x60049F6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60049F7")]
			[Address(RVA = "0x1694D50", Offset = "0x1693950", VA = "0x181694D50")]
			private set
			{
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x16941A0", Offset = "0x1692DA0", VA = "0x1816941A0", Slot = "17")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x1694520", Offset = "0x1693120", VA = "0x181694520")]
		public void Invalidate()
		{
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x1694670", Offset = "0x1693270", VA = "0x181694670")]
		public void MaskMightChanged()
		{
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x1693FF0", Offset = "0x1692BF0", VA = "0x181693FF0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x1694960", Offset = "0x1693560", VA = "0x181694960", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x16948D0", Offset = "0x16934D0", VA = "0x1816948D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x16948A0", Offset = "0x16934A0", VA = "0x1816948A0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049FF")]
		[Address(RVA = "0x1694880", Offset = "0x1693480", VA = "0x181694880", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A00")]
		[Address(RVA = "0x1694880", Offset = "0x1693480", VA = "0x181694880", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A01")]
		[Address(RVA = "0x16949A0", Offset = "0x16935A0", VA = "0x1816949A0")]
		private void OnTransformChildrenChanged()
		{
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A02")]
		[Address(RVA = "0x16949B0", Offset = "0x16935B0", VA = "0x1816949B0")]
		private void RequestChildTransformUpdate()
		{
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06004A03 RID: 18947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		private Graphic graphic
		{
			[Token(Token = "0x6004A03")]
			[Address(RVA = "0x1694C10", Offset = "0x1693810", VA = "0x181694C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06004A04 RID: 18948 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A05 RID: 18949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017D")]
		private Material replacement
		{
			[Token(Token = "0x6004A04")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A05")]
			[Address(RVA = "0x1694E00", Offset = "0x1693A00", VA = "0x181694E00")]
			set
			{
			}
		}

		// Token: 0x06004A06 RID: 18950 RVA: 0x0002C610 File Offset: 0x0002A810
		[Token(Token = "0x6004A06")]
		[Address(RVA = "0x1694020", Offset = "0x1692C20", VA = "0x181694020")]
		private bool FindMaskOrDie()
		{
			return default(bool);
		}

		// Token: 0x06004A07 RID: 18951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A07")]
		[Address(RVA = "0x16946A0", Offset = "0x16932A0", VA = "0x1816946A0")]
		private static ISoftMask NearestMask(Transform transform, out bool processedByThisMask, bool enabledOnly = true)
		{
			return null;
		}

		// Token: 0x06004A08 RID: 18952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A08")]
		[Address(RVA = "0x16940F0", Offset = "0x1692CF0", VA = "0x1816940F0")]
		private static ISoftMask GetISoftMask(Transform current, bool shouldBeEnabled = true)
		{
			return null;
		}

		// Token: 0x06004A09 RID: 18953 RVA: 0x0002C628 File Offset: 0x0002A828
		[Token(Token = "0x6004A09")]
		[Address(RVA = "0x16945D0", Offset = "0x16931D0", VA = "0x1816945D0")]
		private static bool IsOverridingSortingCanvas(Transform transform)
		{
			return default(bool);
		}

		// Token: 0x06004A0A RID: 18954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0A")]
		[Address(RVA = "0x1694AA0", Offset = "0x16936A0", VA = "0x181694AA0")]
		private void SetShaderNotSupported(Material material)
		{
		}

		// Token: 0x06004A0B RID: 18955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A0B")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public SoftMaskable()
		{
		}

		// Token: 0x04000E4E RID: 3662
		[Token(Token = "0x4000E4E")]
		[FieldOffset(Offset = "0x18")]
		private ISoftMask _mask;

		// Token: 0x04000E4F RID: 3663
		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x20")]
		private ISoftMask _cachedMask;

		// Token: 0x04000E50 RID: 3664
		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x28")]
		private Graphic _graphic;

		// Token: 0x04000E51 RID: 3665
		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x30")]
		private Material _replacement;

		// Token: 0x04000E52 RID: 3666
		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x38")]
		private bool _affectedByMask;

		// Token: 0x04000E53 RID: 3667
		[Token(Token = "0x4000E53")]
		[FieldOffset(Offset = "0x39")]
		private bool _destroyed;
	}
}
