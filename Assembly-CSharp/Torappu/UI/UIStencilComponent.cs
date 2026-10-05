using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Stencil;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003766 RID: 14182
	[Token(Token = "0x2003766")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Graphic))]
	public class UIStencilComponent : UIBehaviour, IHotfixable, IMaterialModifier, UIStencilCleaner.INeedClean
	{
		// Token: 0x06016841 RID: 92225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016841")]
		[Address(RVA = "0xF03970", Offset = "0xF02570", VA = "0x180F03970", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06016842 RID: 92226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016842")]
		[Address(RVA = "0xF038F0", Offset = "0xF024F0", VA = "0x180F038F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06016843 RID: 92227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016843")]
		[Address(RVA = "0xF03840", Offset = "0xF02440", VA = "0x180F03840", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06016844 RID: 92228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016844")]
		[Address(RVA = "0xF037A0", Offset = "0xF023A0", VA = "0x180F037A0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x06016845 RID: 92229 RVA: 0x000916F8 File Offset: 0x0008F8F8
		// (set) Token: 0x06016846 RID: 92230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035F2")]
		public StencilChannel readChannel
		{
			[Token(Token = "0x6016845")]
			[Address(RVA = "0xF03CD0", Offset = "0xF028D0", VA = "0x180F03CD0")]
			get
			{
				return StencilChannel.NONE;
			}
			[Token(Token = "0x6016846")]
			[Address(RVA = "0xF03D90", Offset = "0xF02990", VA = "0x180F03D90")]
			set
			{
			}
		}

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x06016847 RID: 92231 RVA: 0x00091710 File Offset: 0x0008F910
		// (set) Token: 0x06016848 RID: 92232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035F3")]
		public StencilChannel writeChannel
		{
			[Token(Token = "0x6016847")]
			[Address(RVA = "0xF03D30", Offset = "0xF02930", VA = "0x180F03D30")]
			get
			{
				return StencilChannel.NONE;
			}
			[Token(Token = "0x6016848")]
			[Address(RVA = "0xF03E70", Offset = "0xF02A70", VA = "0x180F03E70")]
			set
			{
			}
		}

		// Token: 0x06016849 RID: 92233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016849")]
		[Address(RVA = "0xF036B0", Offset = "0xF022B0", VA = "0x180F036B0", Slot = "17")]
		public Material GetModifiedMaterial(Material baseMaterial)
		{
			return null;
		}

		// Token: 0x0601684A RID: 92234 RVA: 0x00091728 File Offset: 0x0008F928
		[Token(Token = "0x601684A")]
		[Address(RVA = "0xF03740", Offset = "0xF02340", VA = "0x180F03740", Slot = "18")]
		public bool NeedCleaner()
		{
			return default(bool);
		}

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0601684B RID: 92235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035F4")]
		public IMatChecker MatChecker
		{
			[Token(Token = "0x601684B")]
			[Address(RVA = "0xF03C70", Offset = "0xF02870", VA = "0x180F03C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601684C RID: 92236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601684C")]
		[Address(RVA = "0xF035B0", Offset = "0xF021B0", VA = "0x180F035B0")]
		public void BindMatChecker(IMatChecker checker)
		{
		}

		// Token: 0x0601684D RID: 92237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601684D")]
		[Address(RVA = "0xF03A80", Offset = "0xF02680", VA = "0x180F03A80")]
		private void _TryActivateCleaner()
		{
		}

		// Token: 0x0601684E RID: 92238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601684E")]
		[Address(RVA = "0xF03B30", Offset = "0xF02730", VA = "0x180F03B30")]
		private void _TryDeactivateCleaner()
		{
		}

		// Token: 0x0601684F RID: 92239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601684F")]
		[Address(RVA = "0xF03BC0", Offset = "0xF027C0", VA = "0x180F03BC0")]
		public UIStencilComponent()
		{
		}

		// Token: 0x06016850 RID: 92240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016850")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06016851 RID: 92241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016851")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x06016852 RID: 92242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016852")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06016853 RID: 92243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016853")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x0401B205 RID: 111109
		[Token(Token = "0x401B205")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Comparison _comp;

		// Token: 0x0401B206 RID: 111110
		[Token(Token = "0x401B206")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Operation _opt;

		// Token: 0x0401B207 RID: 111111
		[Token(Token = "0x401B207")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StencilChannel _readChannel;

		// Token: 0x0401B208 RID: 111112
		[Token(Token = "0x401B208")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private StencilChannel _writeChannel;

		// Token: 0x0401B209 RID: 111113
		[Token(Token = "0x401B209")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ColorWriteMask _colorMask;

		// Token: 0x0401B20A RID: 111114
		[Token(Token = "0x401B20A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Tooltip("Need a host cleaner to clean stencil.")]
		private bool _needCleaner;

		// Token: 0x0401B20B RID: 111115
		[Token(Token = "0x401B20B")]
		[FieldOffset(Offset = "0x30")]
		private UIStencilComponent.Status m_status;

		// Token: 0x0401B20C RID: 111116
		[Token(Token = "0x401B20C")]
		[FieldOffset(Offset = "0x38")]
		private UIStencilCleaner m_stencilCleaner;

		// Token: 0x0401B20D RID: 111117
		[Token(Token = "0x401B20D")]
		[FieldOffset(Offset = "0x40")]
		private IMatChecker m_matChecker;

		// Token: 0x0401B20E RID: 111118
		[Token(Token = "0x401B20E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B20F RID: 111119
		[Token(Token = "0x401B20F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401B210 RID: 111120
		[Token(Token = "0x401B210")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B211 RID: 111121
		[Token(Token = "0x401B211")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCanvasHierarchyChanged;

		// Token: 0x0401B212 RID: 111122
		[Token(Token = "0x401B212")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_readChannel;

		// Token: 0x0401B213 RID: 111123
		[Token(Token = "0x401B213")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_readChannel;

		// Token: 0x0401B214 RID: 111124
		[Token(Token = "0x401B214")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_writeChannel;

		// Token: 0x0401B215 RID: 111125
		[Token(Token = "0x401B215")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_writeChannel;

		// Token: 0x0401B216 RID: 111126
		[Token(Token = "0x401B216")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetModifiedMaterial;

		// Token: 0x0401B217 RID: 111127
		[Token(Token = "0x401B217")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NeedCleaner;

		// Token: 0x0401B218 RID: 111128
		[Token(Token = "0x401B218")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_MatChecker;

		// Token: 0x0401B219 RID: 111129
		[Token(Token = "0x401B219")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_BindMatChecker;

		// Token: 0x0401B21A RID: 111130
		[Token(Token = "0x401B21A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryActivateCleaner;

		// Token: 0x0401B21B RID: 111131
		[Token(Token = "0x401B21B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryDeactivateCleaner;

		// Token: 0x0401B21C RID: 111132
		[Token(Token = "0x401B21C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003767 RID: 14183
		[Token(Token = "0x2003767")]
		private class Status : IDisposable
		{
			// Token: 0x170035F5 RID: 13813
			// (get) Token: 0x06016854 RID: 92244 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016855 RID: 92245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170035F5")]
			public Graphic graphic
			{
				[Token(Token = "0x6016854")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016855")]
				[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170035F6 RID: 13814
			// (get) Token: 0x06016856 RID: 92246 RVA: 0x00091740 File Offset: 0x0008F940
			// (set) Token: 0x06016857 RID: 92247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170035F6")]
			public UIStencilMaterialWrapper currentWrapper
			{
				[Token(Token = "0x6016856")]
				[Address(RVA = "0xEFC660", Offset = "0xEFB260", VA = "0x180EFC660")]
				[CompilerGenerated]
				get
				{
					return default(UIStencilMaterialWrapper);
				}
				[Token(Token = "0x6016857")]
				[Address(RVA = "0xEFC680", Offset = "0xEFB280", VA = "0x180EFC680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06016858 RID: 92248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016858")]
			[Address(RVA = "0xEFC5B0", Offset = "0xEFB1B0", VA = "0x180EFC5B0")]
			public void Resume(UIStencilComponent host)
			{
			}

			// Token: 0x06016859 RID: 92249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016859")]
			[Address(RVA = "0xEFC1E0", Offset = "0xEFADE0", VA = "0x180EFC1E0")]
			public Material ReloadMaterial(UIStencilComponent host, Material baseMaterial)
			{
				return null;
			}

			// Token: 0x0601685A RID: 92250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601685A")]
			[Address(RVA = "0xEFC110", Offset = "0xEFAD10", VA = "0x180EFC110")]
			public void Disable()
			{
			}

			// Token: 0x0601685B RID: 92251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601685B")]
			[Address(RVA = "0xEFC1B0", Offset = "0xEFADB0", VA = "0x180EFC1B0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0601685C RID: 92252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601685C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Status()
			{
			}

			// Token: 0x0401B21D RID: 111133
			[Token(Token = "0x401B21D")]
			[FieldOffset(Offset = "0x10")]
			private Material m_material;

			// Token: 0x0401B21E RID: 111134
			[Token(Token = "0x401B21E")]
			[FieldOffset(Offset = "0x18")]
			private UIStencilMaterialWrapper m_currentWrapper;
		}
	}
}
