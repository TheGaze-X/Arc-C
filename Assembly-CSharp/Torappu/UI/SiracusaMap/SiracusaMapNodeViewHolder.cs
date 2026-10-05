using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F8F RID: 16271
	[Token(Token = "0x2003F8F")]
	public abstract class SiracusaMapNodeViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x060193DE RID: 103390 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060193DF RID: 103391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C43")]
		public AutoPackSpriteHub areaIconSpriteHub
		{
			[Token(Token = "0x60193DE")]
			[Address(RVA = "0x11EEA80", Offset = "0x11ED680", VA = "0x1811EEA80")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60193DF")]
			[Address(RVA = "0x11EEB40", Offset = "0x11ED740", VA = "0x1811EEB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x060193E0 RID: 103392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C44")]
		public string pointId
		{
			[Token(Token = "0x60193E0")]
			[Address(RVA = "0x11EEAE0", Offset = "0x11ED6E0", VA = "0x1811EEAE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060193E1 RID: 103393
		[Token(Token = "0x60193E1")]
		public abstract void Render(SiracusaMapMapNodeViewModel viewModel);

		// Token: 0x060193E2 RID: 103394
		[Token(Token = "0x60193E2")]
		public abstract void Reset();

		// Token: 0x060193E3 RID: 103395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193E3")]
		[Address(RVA = "0x11EEA20", Offset = "0x11ED620", VA = "0x1811EEA20")]
		protected SiracusaMapNodeViewHolder()
		{
		}

		// Token: 0x0401F526 RID: 128294
		[Token(Token = "0x401F526")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected RectTransform _normalNodeContainer;

		// Token: 0x0401F527 RID: 128295
		[Token(Token = "0x401F527")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected RectTransform _selectedNodeContainer;

		// Token: 0x0401F528 RID: 128296
		[Token(Token = "0x401F528")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected RectTransform _taskNodeContainer;

		// Token: 0x0401F529 RID: 128297
		[Token(Token = "0x401F529")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected SiracusaMapNodeViewBase _normalNodePrefab;

		// Token: 0x0401F52A RID: 128298
		[Token(Token = "0x401F52A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected SiracusaMapNodeViewBase _taskNodePrefab;

		// Token: 0x0401F52B RID: 128299
		[Token(Token = "0x401F52B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected SiracusaMapNodeViewBase _selectedNodePrefab;

		// Token: 0x0401F52C RID: 128300
		[Token(Token = "0x401F52C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private string _pointId;

		// Token: 0x0401F52E RID: 128302
		[Token(Token = "0x401F52E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_areaIconSpriteHub;

		// Token: 0x0401F52F RID: 128303
		[Token(Token = "0x401F52F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_areaIconSpriteHub;

		// Token: 0x0401F530 RID: 128304
		[Token(Token = "0x401F530")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_pointId;

		// Token: 0x0401F531 RID: 128305
		[Token(Token = "0x401F531")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
