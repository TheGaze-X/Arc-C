using System;
using Il2CppDummyDll;
using Torappu.UI.Stencil;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200376A RID: 14186
	[Token(Token = "0x200376A")]
	[ExecuteInEditMode]
	public class UIStencilGraphic : UIStencilMaskable, UIStencilCleaner.INeedClean
	{
		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x06016864 RID: 92260 RVA: 0x000917A0 File Offset: 0x0008F9A0
		// (set) Token: 0x06016865 RID: 92261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035F7")]
		public override bool raycastTarget
		{
			[Token(Token = "0x6016864")]
			[Address(RVA = "0xF04B80", Offset = "0xF03780", VA = "0x180F04B80", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016865")]
			[Address(RVA = "0xF04CA0", Offset = "0xF038A0", VA = "0x180F04CA0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x06016866 RID: 92262 RVA: 0x000917B8 File Offset: 0x0008F9B8
		// (set) Token: 0x06016867 RID: 92263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035F8")]
		public StencilChannel readChannel
		{
			[Token(Token = "0x6016866")]
			[Address(RVA = "0xF04BE0", Offset = "0xF037E0", VA = "0x180F04BE0")]
			get
			{
				return StencilChannel.NONE;
			}
			[Token(Token = "0x6016867")]
			[Address(RVA = "0xF04D10", Offset = "0xF03910", VA = "0x180F04D10")]
			set
			{
			}
		}

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x06016868 RID: 92264 RVA: 0x000917D0 File Offset: 0x0008F9D0
		// (set) Token: 0x06016869 RID: 92265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035F9")]
		public StencilChannel writeChannel
		{
			[Token(Token = "0x6016868")]
			[Address(RVA = "0xF04C40", Offset = "0xF03840", VA = "0x180F04C40")]
			get
			{
				return StencilChannel.NONE;
			}
			[Token(Token = "0x6016869")]
			[Address(RVA = "0xF04DC0", Offset = "0xF039C0", VA = "0x180F04DC0")]
			set
			{
			}
		}

		// Token: 0x0601686A RID: 92266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601686A")]
		[Address(RVA = "0xF04770", Offset = "0xF03370", VA = "0x180F04770", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0601686B RID: 92267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601686B")]
		[Address(RVA = "0xF04680", Offset = "0xF03280", VA = "0x180F04680", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0601686C RID: 92268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601686C")]
		[Address(RVA = "0xF044E0", Offset = "0xF030E0", VA = "0x180F044E0", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x0601686D RID: 92269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601686D")]
		[Address(RVA = "0xF04580", Offset = "0xF03180", VA = "0x180F04580", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0601686E RID: 92270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035FA")]
		public override Material materialForRendering
		{
			[Token(Token = "0x601686E")]
			[Address(RVA = "0xF049D0", Offset = "0xF035D0", VA = "0x180F049D0", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601686F RID: 92271 RVA: 0x000917E8 File Offset: 0x0008F9E8
		[Token(Token = "0x601686F")]
		[Address(RVA = "0xF04480", Offset = "0xF03080", VA = "0x180F04480", Slot = "58")]
		public bool NeedCleaner()
		{
			return default(bool);
		}

		// Token: 0x06016870 RID: 92272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016870")]
		[Address(RVA = "0xF04810", Offset = "0xF03410", VA = "0x180F04810")]
		private void _TryActivateCleaner()
		{
		}

		// Token: 0x06016871 RID: 92273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016871")]
		[Address(RVA = "0xF048C0", Offset = "0xF034C0", VA = "0x180F048C0")]
		private void _TryDeactivateCleaner()
		{
		}

		// Token: 0x06016872 RID: 92274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016872")]
		[Address(RVA = "0xF04960", Offset = "0xF03560", VA = "0x180F04960")]
		public UIStencilGraphic()
		{
		}

		// Token: 0x06016873 RID: 92275 RVA: 0x00091800 File Offset: 0x0008FA00
		[Token(Token = "0x6016873")]
		[Address(RVA = "0xF02F50", Offset = "0xF01B50", VA = "0x180F02F50")]
		private bool <>xLuaBaseProxy_get_raycastTarget()
		{
			return default(bool);
		}

		// Token: 0x06016874 RID: 92276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016874")]
		[Address(RVA = "0xF02F60", Offset = "0xF01B60", VA = "0x180F02F60")]
		private void <>xLuaBaseProxy_set_raycastTarget(bool P0)
		{
		}

		// Token: 0x06016875 RID: 92277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016875")]
		[Address(RVA = "0xF02F30", Offset = "0xF01B30", VA = "0x180F02F30")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06016876 RID: 92278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016876")]
		[Address(RVA = "0xF02F20", Offset = "0xF01B20", VA = "0x180F02F20")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x06016877 RID: 92279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016877")]
		[Address(RVA = "0xF04800", Offset = "0xF03400", VA = "0x180F04800")]
		private void <>xLuaBaseProxy_OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x06016878 RID: 92280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016878")]
		[Address(RVA = "0xF02F10", Offset = "0xF01B10", VA = "0x180F02F10")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06016879 RID: 92281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016879")]
		[Address(RVA = "0xF02F40", Offset = "0xF01B40", VA = "0x180F02F40")]
		private Material <>xLuaBaseProxy_get_materialForRendering()
		{
			return null;
		}

		// Token: 0x0401B227 RID: 111143
		[Token(Token = "0x401B227")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Comparison _comp;

		// Token: 0x0401B228 RID: 111144
		[Token(Token = "0x401B228")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private Operation _opt;

		// Token: 0x0401B229 RID: 111145
		[Token(Token = "0x401B229")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private StencilChannel _readChannel;

		// Token: 0x0401B22A RID: 111146
		[Token(Token = "0x401B22A")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private StencilChannel _writeChannel;

		// Token: 0x0401B22B RID: 111147
		[Token(Token = "0x401B22B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ColorWriteMask _colorMask;

		// Token: 0x0401B22C RID: 111148
		[Token(Token = "0x401B22C")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private bool _blockRaycast;

		// Token: 0x0401B22D RID: 111149
		[Token(Token = "0x401B22D")]
		[FieldOffset(Offset = "0xD5")]
		[SerializeField]
		[Tooltip("Need a host cleaner to clean stencil.")]
		private bool _needCleaner;

		// Token: 0x0401B22E RID: 111150
		[Token(Token = "0x401B22E")]
		[FieldOffset(Offset = "0xD8")]
		private Material m_maskMaterial;

		// Token: 0x0401B22F RID: 111151
		[Token(Token = "0x401B22F")]
		[FieldOffset(Offset = "0xE0")]
		private UIStencilCleaner m_stencilCleaner;

		// Token: 0x0401B230 RID: 111152
		[Token(Token = "0x401B230")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_raycastTarget;

		// Token: 0x0401B231 RID: 111153
		[Token(Token = "0x401B231")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_raycastTarget;

		// Token: 0x0401B232 RID: 111154
		[Token(Token = "0x401B232")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_readChannel;

		// Token: 0x0401B233 RID: 111155
		[Token(Token = "0x401B233")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_readChannel;

		// Token: 0x0401B234 RID: 111156
		[Token(Token = "0x401B234")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_writeChannel;

		// Token: 0x0401B235 RID: 111157
		[Token(Token = "0x401B235")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_writeChannel;

		// Token: 0x0401B236 RID: 111158
		[Token(Token = "0x401B236")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401B237 RID: 111159
		[Token(Token = "0x401B237")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401B238 RID: 111160
		[Token(Token = "0x401B238")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCanvasHierarchyChanged;

		// Token: 0x0401B239 RID: 111161
		[Token(Token = "0x401B239")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B23A RID: 111162
		[Token(Token = "0x401B23A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_materialForRendering;

		// Token: 0x0401B23B RID: 111163
		[Token(Token = "0x401B23B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NeedCleaner;

		// Token: 0x0401B23C RID: 111164
		[Token(Token = "0x401B23C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryActivateCleaner;

		// Token: 0x0401B23D RID: 111165
		[Token(Token = "0x401B23D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryDeactivateCleaner;

		// Token: 0x0401B23E RID: 111166
		[Token(Token = "0x401B23E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
