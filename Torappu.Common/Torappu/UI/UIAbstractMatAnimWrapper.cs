using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[ExecuteInEditMode]
	public abstract class UIAbstractMatAnimWrapper : MonoBehaviour, IHotfixable
	{
		// Token: 0x060007FA RID: 2042
		[Token(Token = "0x60007FA")]
		public abstract Material GetMaterial();

		// Token: 0x060007FB RID: 2043
		[Token(Token = "0x60007FB")]
		public abstract void CleanMaterial();

		// Token: 0x060007FC RID: 2044 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x5539930", Offset = "0x5538530", VA = "0x185539930")]
		private void OnEnable()
		{
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x5539880", Offset = "0x5538480", VA = "0x185539880")]
		private void OnDisable()
		{
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x5539F70", Offset = "0x5538B70", VA = "0x185539F70")]
		public void UpdateTick()
		{
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x5539A60", Offset = "0x5538660", VA = "0x185539A60")]
		protected void Tick()
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00006C5C File Offset: 0x00004E5C
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x5538A80", Offset = "0x5537680", VA = "0x185538A80")]
		protected bool InitTick()
		{
			return default(bool);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00006C74 File Offset: 0x00004E74
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x553A4A0", Offset = "0x55390A0", VA = "0x18553A4A0")]
		private bool _SetValue(Material mat, UIAbstractMatAnimWrapper.ColorProperty property, bool isFirst = false)
		{
			return default(bool);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00006C8C File Offset: 0x00004E8C
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x553A360", Offset = "0x5538F60", VA = "0x18553A360")]
		private bool _SetValue(Material mat, UIAbstractMatAnimWrapper.FloatProperty property, bool isFirst = false)
		{
			return default(bool);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x5539FE0", Offset = "0x5538BE0", VA = "0x185539FE0")]
		private bool _SetValue(Material mat, UIAbstractMatAnimWrapper.TextureTileProperty property, bool isFirst = false)
		{
			return default(bool);
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00006CBC File Offset: 0x00004EBC
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x553A1C0", Offset = "0x5538DC0", VA = "0x18553A1C0")]
		private bool _SetValue(Material mat, UIAbstractMatAnimWrapper.Vector4Property property, bool isFirst = false)
		{
			return default(bool);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x553A660", Offset = "0x5539260", VA = "0x18553A660")]
		protected UIAbstractMatAnimWrapper()
		{
		}

		// Token: 0x04000730 RID: 1840
		[Token(Token = "0x4000730")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.ColorProperty _colorProperty1;

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.ColorProperty _colorProperty2;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.ColorProperty _colorProperty3;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.ColorProperty _colorProperty4;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.ColorProperty _colorProperty5;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.FloatProperty _floatProperty1;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.FloatProperty _floatProperty2;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.FloatProperty _floatProperty3;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.FloatProperty _floatProperty4;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.FloatProperty _floatProperty5;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.TextureTileProperty _textureProperty1;

		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.TextureTileProperty _textureProperty2;

		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.TextureTileProperty _textureProperty3;

		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.TextureTileProperty _textureProperty4;

		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.TextureTileProperty _textureProperty5;

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.Vector4Property _vector4Property1;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.Vector4Property _vector4Property2;

		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		[FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.Vector4Property _vector4Property3;

		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		[FieldOffset(Offset = "0x300")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.Vector4Property _vector4Property4;

		// Token: 0x04000743 RID: 1859
		[Token(Token = "0x4000743")]
		[FieldOffset(Offset = "0x330")]
		[SerializeField]
		private UIAbstractMatAnimWrapper.Vector4Property _vector4Property5;

		// Token: 0x04000744 RID: 1860
		[Token(Token = "0x4000744")]
		[FieldOffset(Offset = "0x360")]
		protected bool tickFlag;

		// Token: 0x04000745 RID: 1861
		[Token(Token = "0x4000745")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnEnable;

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnDisable;

		// Token: 0x04000747 RID: 1863
		[Token(Token = "0x4000747")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_UpdateTick;

		// Token: 0x04000748 RID: 1864
		[Token(Token = "0x4000748")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_Tick;

		// Token: 0x04000749 RID: 1865
		[Token(Token = "0x4000749")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate21 __Hotfix0_InitTick;

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate155 __Hotfix0__SetValue;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate156 __Hotfix1__SetValue;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate157 __Hotfix2__SetValue;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate158 __Hotfix3__SetValue;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x2000154")]
		[Serializable]
		public struct ColorProperty
		{
			// Token: 0x0400074F RID: 1871
			[Token(Token = "0x400074F")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000750 RID: 1872
			[Token(Token = "0x4000750")]
			[FieldOffset(Offset = "0x8")]
			public bool enable;

			// Token: 0x04000751 RID: 1873
			[Token(Token = "0x4000751")]
			[FieldOffset(Offset = "0xC")]
			public Color color;

			// Token: 0x04000752 RID: 1874
			[Token(Token = "0x4000752")]
			[FieldOffset(Offset = "0x1C")]
			[NonSerialized]
			public Color cacheColor;
		}

		// Token: 0x02000155 RID: 341
		[Token(Token = "0x2000155")]
		[Serializable]
		public struct FloatProperty
		{
			// Token: 0x04000753 RID: 1875
			[Token(Token = "0x4000753")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000754 RID: 1876
			[Token(Token = "0x4000754")]
			[FieldOffset(Offset = "0x8")]
			public bool enable;

			// Token: 0x04000755 RID: 1877
			[Token(Token = "0x4000755")]
			[FieldOffset(Offset = "0xC")]
			public float floatValue;

			// Token: 0x04000756 RID: 1878
			[Token(Token = "0x4000756")]
			[FieldOffset(Offset = "0x10")]
			[NonSerialized]
			public float cachefloat;
		}

		// Token: 0x02000156 RID: 342
		[Token(Token = "0x2000156")]
		[Serializable]
		public struct TextureTileProperty
		{
			// Token: 0x04000757 RID: 1879
			[Token(Token = "0x4000757")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000758 RID: 1880
			[Token(Token = "0x4000758")]
			[FieldOffset(Offset = "0x8")]
			public bool enable;

			// Token: 0x04000759 RID: 1881
			[Token(Token = "0x4000759")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 tiling;

			// Token: 0x0400075A RID: 1882
			[Token(Token = "0x400075A")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 offset;

			// Token: 0x0400075B RID: 1883
			[Token(Token = "0x400075B")]
			[FieldOffset(Offset = "0x1C")]
			[NonSerialized]
			public Vector2 cacheTiling;

			// Token: 0x0400075C RID: 1884
			[Token(Token = "0x400075C")]
			[FieldOffset(Offset = "0x24")]
			[NonSerialized]
			public Vector2 cacheOffset;
		}

		// Token: 0x02000157 RID: 343
		[Token(Token = "0x2000157")]
		[Serializable]
		public struct Vector4Property
		{
			// Token: 0x0400075D RID: 1885
			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400075E RID: 1886
			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0x8")]
			public bool enable;

			// Token: 0x0400075F RID: 1887
			[Token(Token = "0x400075F")]
			[FieldOffset(Offset = "0xC")]
			public Vector4 value;

			// Token: 0x04000760 RID: 1888
			[Token(Token = "0x4000760")]
			[FieldOffset(Offset = "0x1C")]
			[NonSerialized]
			public Vector4 cacheValue;
		}
	}
}
