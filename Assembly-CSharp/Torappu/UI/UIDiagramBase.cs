using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039E4 RID: 14820
	[Token(Token = "0x20039E4")]
	public abstract class UIDiagramBase<PointView> : MonoBehaviour, IHotfixable where PointView : Component
	{
		// Token: 0x0601767C RID: 95868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601767C")]
		public void RenderDiagram(UIDiagramBase<PointView>.IDataSource data)
		{
		}

		// Token: 0x0601767D RID: 95869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601767D")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601767E RID: 95870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601767E")]
		private void _Clear()
		{
		}

		// Token: 0x0601767F RID: 95871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601767F")]
		public T GetDataSource<T>() where T : UIDiagramBase<PointView>.IDataSource
		{
			return null;
		}

		// Token: 0x06017680 RID: 95872
		[Token(Token = "0x6017680")]
		protected abstract PointView GetPrefab(string key);

		// Token: 0x06017681 RID: 95873
		[Token(Token = "0x6017681")]
		protected abstract void RenderNode(string key, PointView obj);

		// Token: 0x06017682 RID: 95874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017682")]
		protected UIDiagramBase()
		{
		}

		// Token: 0x0401C451 RID: 115793
		[Token(Token = "0x401C451")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private UIDiagramBase<PointView>.LineGroup[] _lineGroups;

		// Token: 0x0401C452 RID: 115794
		[Token(Token = "0x401C452")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _pointContainer;

		// Token: 0x0401C453 RID: 115795
		[Token(Token = "0x401C453")]
		[FieldOffset(Offset = "0x0")]
		private UIDiagramBase<PointView>.PointViewPool m_pointPool;

		// Token: 0x0401C454 RID: 115796
		[Token(Token = "0x401C454")]
		[FieldOffset(Offset = "0x0")]
		private UIDiagramBase<PointView>.IDataSource m_dataSource;

		// Token: 0x0401C455 RID: 115797
		[Token(Token = "0x401C455")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderDiagram;

		// Token: 0x0401C456 RID: 115798
		[Token(Token = "0x401C456")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C457 RID: 115799
		[Token(Token = "0x401C457")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Clear;

		// Token: 0x0401C458 RID: 115800
		[Token(Token = "0x401C458")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataSource;

		// Token: 0x0401C459 RID: 115801
		[Token(Token = "0x401C459")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020039E5 RID: 14821
		[Token(Token = "0x20039E5")]
		[Serializable]
		private class LineGroup
		{
			// Token: 0x06017683 RID: 95875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017683")]
			public LineGroup()
			{
			}

			// Token: 0x0401C45A RID: 115802
			[Token(Token = "0x401C45A")]
			[FieldOffset(Offset = "0x0")]
			public CustomLineGraphic lineGraphic;

			// Token: 0x0401C45B RID: 115803
			[Token(Token = "0x401C45B")]
			[FieldOffset(Offset = "0x0")]
			public CustomLineGraphic shadowGraphic;
		}

		// Token: 0x020039E6 RID: 14822
		[Token(Token = "0x20039E6")]
		private class PointViewPool : GameObjectDictPool<PointView>
		{
			// Token: 0x06017684 RID: 95876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017684")]
			public PointViewPool(UIDiagramBase<PointView> closure)
			{
			}

			// Token: 0x06017685 RID: 95877 RVA: 0x00096558 File Offset: 0x00094758
			[Token(Token = "0x6017685")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x06017686 RID: 95878 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017686")]
			protected override PointView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x06017687 RID: 95879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017687")]
			protected override PointView Instantiate(string key, PointView prefab)
			{
				return null;
			}

			// Token: 0x06017688 RID: 95880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017688")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x06017689 RID: 95881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017689")]
			protected override void Render(string key, PointView obj)
			{
			}

			// Token: 0x0401C45C RID: 115804
			[Token(Token = "0x401C45C")]
			[FieldOffset(Offset = "0x0")]
			private UIDiagramBase<PointView> m_closure;

			// Token: 0x0401C45D RID: 115805
			[Token(Token = "0x401C45D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401C45E RID: 115806
			[Token(Token = "0x401C45E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x0401C45F RID: 115807
			[Token(Token = "0x401C45F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401C460 RID: 115808
			[Token(Token = "0x401C460")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x0401C461 RID: 115809
			[Token(Token = "0x401C461")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x0401C462 RID: 115810
			[Token(Token = "0x401C462")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x020039E7 RID: 14823
		[Token(Token = "0x20039E7")]
		public interface IDataSource
		{
			// Token: 0x17003810 RID: 14352
			// (get) Token: 0x0601768A RID: 95882
			[Token(Token = "0x17003810")]
			Vector2 diagramSize { [Token(Token = "0x601768A")] get; }

			// Token: 0x0601768B RID: 95883
			[Token(Token = "0x601768B")]
			bool ContainsKey(string key);

			// Token: 0x0601768C RID: 95884
			[Token(Token = "0x601768C")]
			IEnumerable<string> IterKeys();

			// Token: 0x0601768D RID: 95885
			[Token(Token = "0x601768D")]
			void FillLinePos(int grpIdx, List<Vector2> linePointList);
		}
	}
}
