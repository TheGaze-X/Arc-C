using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	internal class RenderChain : IDisposable
	{
		// Token: 0x0600126A RID: 4714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126A")]
		[Address(RVA = "0x5B42250", Offset = "0x5B40E50", VA = "0x185B42250")]
		public RenderChain(BaseVisualElementPanel panel)
		{
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x5B3D8E0", Offset = "0x5B3C4E0", VA = "0x185B3D8E0")]
		private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan)
		{
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x5B3DE00", Offset = "0x5B3CA00", VA = "0x185B3DE00")]
		private void Destructor()
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00009D98 File Offset: 0x00007F98
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049B")]
		private protected bool disposed
		{
			[Token(Token = "0x600126D")]
			[Address(RVA = "0x4DA7640", Offset = "0x4DA6240", VA = "0x184DA7640")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600126E")]
			[Address(RVA = "0x4DA7720", Offset = "0x4DA6320", VA = "0x184DA7720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x5B3E240", Offset = "0x5B3CE40", VA = "0x185B3E240", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x5B3E210", Offset = "0x5B3CE10", VA = "0x185B3E210")]
		protected void Dispose(bool disposing)
		{
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x5B3FFC0", Offset = "0x5B3EBC0", VA = "0x185B3FFC0")]
		public void ProcessChanges()
		{
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x5B40B80", Offset = "0x5B3F780", VA = "0x185B40B80")]
		public void Render()
		{
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x5B407F0", Offset = "0x5B3F3F0", VA = "0x185B407F0")]
		private void ProcessTextRegen(bool timeSliced)
		{
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x5B41360", Offset = "0x5B3FF60", VA = "0x185B41360")]
		public void UIEOnChildAdded(VisualElement ve)
		{
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001275")]
		[Address(RVA = "0x5B41780", Offset = "0x5B40380", VA = "0x185B41780")]
		public void UIEOnChildrenReordered(VisualElement ve)
		{
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001276")]
		[Address(RVA = "0x5B41670", Offset = "0x5B40270", VA = "0x185B41670")]
		public void UIEOnChildRemoving(VisualElement ve)
		{
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001277")]
		[Address(RVA = "0x5B41300", Offset = "0x5B3FF00", VA = "0x185B41300")]
		public void StopTrackingGroupTransformElement(VisualElement ve)
		{
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001278")]
		[Address(RVA = "0x5B41C90", Offset = "0x5B40890", VA = "0x185B41C90")]
		public void UIEOnRenderHintsChanged(VisualElement ve)
		{
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001279")]
		[Address(RVA = "0x5B41AA0", Offset = "0x5B406A0", VA = "0x185B41AA0")]
		public void UIEOnClippingChanged(VisualElement ve, bool hierarchical)
		{
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x5B41BE0", Offset = "0x5B407E0", VA = "0x185B41BE0")]
		public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical = false)
		{
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x5B41B40", Offset = "0x5B40740", VA = "0x185B41B40")]
		public void UIEOnColorChanged(VisualElement ve)
		{
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x5B41E50", Offset = "0x5B40A50", VA = "0x185B41E50")]
		public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged)
		{
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x5B41F00", Offset = "0x5B40B00", VA = "0x185B41F00")]
		public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical)
		{
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049C")]
		internal BaseVisualElementPanel panel
		{
			[Token(Token = "0x600127E")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600127F")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049D")]
		internal UIRenderDevice device
		{
			[Token(Token = "0x6001280")]
			[Address(RVA = "0x4FA1B40", Offset = "0x4FA0740", VA = "0x184FA1B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001281")]
			[Address(RVA = "0x55FB9E0", Offset = "0x55FA5E0", VA = "0x1855FB9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049E")]
		internal AtlasBase atlas
		{
			[Token(Token = "0x6001282")]
			[Address(RVA = "0x55FB9D0", Offset = "0x55FA5D0", VA = "0x1855FB9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001283")]
			[Address(RVA = "0x55FB9F0", Offset = "0x55FA5F0", VA = "0x1855FB9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049F")]
		internal VectorImageManager vectorImageManager
		{
			[Token(Token = "0x6001284")]
			[Address(RVA = "0x5080A80", Offset = "0x507F680", VA = "0x185080A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001285")]
			[Address(RVA = "0x538FC10", Offset = "0x538E810", VA = "0x18538FC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A0")]
		internal UIRStylePainter painter
		{
			[Token(Token = "0x6001286")]
			[Address(RVA = "0x55DCE20", Offset = "0x55DBA20", VA = "0x1855DCE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001287")]
			[Address(RVA = "0x4FA2340", Offset = "0x4FA0F40", VA = "0x184FA2340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00009DB0 File Offset: 0x00007FB0
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A1")]
		internal bool drawStats
		{
			[Token(Token = "0x6001288")]
			[Address(RVA = "0x5B42700", Offset = "0x5B41300", VA = "0x185B42700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001289")]
			[Address(RVA = "0x5B428C0", Offset = "0x5B414C0", VA = "0x185B428C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x00009DC8 File Offset: 0x00007FC8
		// (set) Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A2")]
		internal bool drawInCameras
		{
			[Token(Token = "0x600128A")]
			[Address(RVA = "0x5B426F0", Offset = "0x5B412F0", VA = "0x185B426F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600128B")]
			[Address(RVA = "0x5B428B0", Offset = "0x5B414B0", VA = "0x185B428B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (set) Token: 0x0600128C RID: 4748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A3")]
		internal Shader defaultShader
		{
			[Token(Token = "0x600128C")]
			[Address(RVA = "0x5B42710", Offset = "0x5B41310", VA = "0x185B42710")]
			set
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (set) Token: 0x0600128D RID: 4749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A4")]
		internal Shader defaultWorldSpaceShader
		{
			[Token(Token = "0x600128D")]
			[Address(RVA = "0x5B427E0", Offset = "0x5B413E0", VA = "0x185B427E0")]
			set
			{
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x5B3F070", Offset = "0x5B3DC70", VA = "0x185B3F070")]
		internal Material GetStandardMaterial()
		{
			return null;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x5B3F180", Offset = "0x5B3DD80", VA = "0x185B3F180")]
		internal Material GetStandardWorldSpaceMaterial()
		{
			return null;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x5B3EF80", Offset = "0x5B3DB80", VA = "0x185B3EF80")]
		internal void EnsureFitsDepth(int depth)
		{
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x5B3D830", Offset = "0x5B3C430", VA = "0x185B3D830")]
		internal void ChildWillBeRemoved(VisualElement ve)
		{
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x5B3D710", Offset = "0x5B3C310", VA = "0x185B3D710")]
		internal RenderChainCommand AllocCommand()
		{
			return null;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x5B3EF90", Offset = "0x5B3DB90", VA = "0x185B3EF90")]
		internal void FreeCommand(RenderChainCommand cmd)
		{
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x5B3FD00", Offset = "0x5B3E900", VA = "0x185B3FD00")]
		internal void OnRenderCommandAdded(RenderChainCommand command)
		{
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x5B3FD90", Offset = "0x5B3E990", VA = "0x185B3FD90")]
		internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand)
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x5B3D690", Offset = "0x5B3C290", VA = "0x185B3D690")]
		internal void AddTextElement(VisualElement ve)
		{
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x5B40AC0", Offset = "0x5B3F6C0", VA = "0x185B40AC0")]
		internal void RemoveTextElement(VisualElement ve)
		{
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x5B3F2A0", Offset = "0x5B3DEA0", VA = "0x185B3F2A0")]
		internal void OnGroupTransformElementChangedTransform(VisualElement ve)
		{
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x5B3D540", Offset = "0x5B3C140", VA = "0x185B3D540")]
		private static RenderChain.RenderNodeData AccessRenderNodeData(IntPtr obj)
		{
			return default(RenderChain.RenderNodeData);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x5B3FDD0", Offset = "0x5B3E9D0", VA = "0x185B3FDD0")]
		private static void OnRenderNodeExecute(IntPtr obj)
		{
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x5B3F7B0", Offset = "0x5B3E3B0", VA = "0x185B3F7B0")]
		private static void OnRegisterIntermediateRenderers(Camera camera)
		{
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x5B3F410", Offset = "0x5B3E010", VA = "0x185B3F410")]
		private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderChain.RenderNodeData rnd, Camera camera, int sameDistanceSortPriority)
		{
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x5B41080", Offset = "0x5B3FC80", VA = "0x185B41080")]
		internal void RepaintTexturedElements()
		{
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x5B3F290", Offset = "0x5B3DE90", VA = "0x185B3F290")]
		private void OnFontReset(Font font)
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x5B3D770", Offset = "0x5B3C370", VA = "0x185B3D770")]
		public void AppendTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas)
		{
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A0")]
		[Address(RVA = "0x5B411E0", Offset = "0x5B3FDE0", VA = "0x185B411E0")]
		public void ResetTextures(VisualElement ve)
		{
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A1")]
		[Address(RVA = "0x5B3E2B0", Offset = "0x5B3CEB0", VA = "0x185B3E2B0")]
		private void DrawStats()
		{
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60012A2")]
		[Address(RVA = "0x5B3F040", Offset = "0x5B3DC40", VA = "0x185B3F040")]
		private static VisualElement GetFirstElementInPanel(VisualElement ve)
		{
			return null;
		}

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x10")]
		private RenderChainCommand m_FirstCommand;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x18")]
		private RenderChain.DepthOrderedDirtyTracking m_DirtyTracker;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x40")]
		private LinkedPool<RenderChainCommand> m_CommandPool;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x48")]
		private BasicNodePool<TextureEntry> m_TexturePool;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x50")]
		private List<RenderChain.RenderNodeData> m_RenderNodesData;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x58")]
		private Shader m_DefaultShader;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x60")]
		private Shader m_DefaultWorldSpaceShader;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x68")]
		private Material m_DefaultMat;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x70")]
		private Material m_DefaultWorldSpaceMat;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[FieldOffset(Offset = "0x78")]
		private bool m_BlockDirtyRegistration;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[FieldOffset(Offset = "0x7C")]
		private int m_StaticIndex;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[FieldOffset(Offset = "0x80")]
		private int m_ActiveRenderNodes;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[FieldOffset(Offset = "0x84")]
		private int m_CustomMaterialCommands;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[FieldOffset(Offset = "0x88")]
		private ChainBuilderStats m_Stats;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[FieldOffset(Offset = "0xE8")]
		private uint m_StatsElementsAdded;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[FieldOffset(Offset = "0xEC")]
		private uint m_StatsElementsRemoved;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[FieldOffset(Offset = "0xF0")]
		private VisualElement m_FirstTextElement;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[FieldOffset(Offset = "0xF8")]
		private UIRTextUpdatePainter m_TextUpdatePainter;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[FieldOffset(Offset = "0x100")]
		private int m_TextElementCount;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[FieldOffset(Offset = "0x104")]
		private int m_DirtyTextStartIndex;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[FieldOffset(Offset = "0x108")]
		private int m_DirtyTextRemaining;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[FieldOffset(Offset = "0x10C")]
		private bool m_FontWasReset;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[FieldOffset(Offset = "0x110")]
		private Dictionary<VisualElement, Vector2> m_LastGroupTransformElementScale;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[FieldOffset(Offset = "0x118")]
		private TextureRegistry m_TextureRegistry;

		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker s_MarkerProcess;

		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker s_MarkerClipProcessing;

		// Token: 0x040009E7 RID: 2535
		[Token(Token = "0x40009E7")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker s_MarkerOpacityProcessing;

		// Token: 0x040009E8 RID: 2536
		[Token(Token = "0x40009E8")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker s_MarkerColorsProcessing;

		// Token: 0x040009E9 RID: 2537
		[Token(Token = "0x40009E9")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker s_MarkerTransformProcessing;

		// Token: 0x040009EA RID: 2538
		[Token(Token = "0x40009EA")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker s_MarkerVisualsProcessing;

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker s_MarkerTextRegen;

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x38")]
		internal static Action OnPreRender;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[FieldOffset(Offset = "0x148")]
		internal UIRVEShaderInfoAllocator shaderInfoAllocator;

		// Token: 0x020002A2 RID: 674
		[Token(Token = "0x20002A2")]
		private struct DepthOrderedDirtyTracking
		{
			// Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012A3")]
			[Address(RVA = "0x5B33F90", Offset = "0x5B32B90", VA = "0x185B33F90")]
			public void EnsureFits(int maxDepth)
			{
			}

			// Token: 0x060012A4 RID: 4772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012A4")]
			[Address(RVA = "0x5B340E0", Offset = "0x5B32CE0", VA = "0x185B340E0")]
			public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass)
			{
			}

			// Token: 0x060012A5 RID: 4773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012A5")]
			[Address(RVA = "0x5B33DA0", Offset = "0x5B329A0", VA = "0x185B33DA0")]
			public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse)
			{
			}

			// Token: 0x060012A6 RID: 4774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012A6")]
			[Address(RVA = "0x5B342E0", Offset = "0x5B32EE0", VA = "0x185B342E0")]
			public void Reset()
			{
			}

			// Token: 0x040009F6 RID: 2550
			[Token(Token = "0x40009F6")]
			[FieldOffset(Offset = "0x0")]
			public List<VisualElement> heads;

			// Token: 0x040009F7 RID: 2551
			[Token(Token = "0x40009F7")]
			[FieldOffset(Offset = "0x8")]
			public List<VisualElement> tails;

			// Token: 0x040009F8 RID: 2552
			[Token(Token = "0x40009F8")]
			[FieldOffset(Offset = "0x10")]
			public int[] minDepths;

			// Token: 0x040009F9 RID: 2553
			[Token(Token = "0x40009F9")]
			[FieldOffset(Offset = "0x18")]
			public int[] maxDepths;

			// Token: 0x040009FA RID: 2554
			[Token(Token = "0x40009FA")]
			[FieldOffset(Offset = "0x20")]
			public uint dirtyID;
		}

		// Token: 0x020002A3 RID: 675
		[Token(Token = "0x20002A3")]
		private struct RenderChainStaticIndexAllocator
		{
			// Token: 0x060012A7 RID: 4775 RVA: 0x00009DF8 File Offset: 0x00007FF8
			[Token(Token = "0x60012A7")]
			[Address(RVA = "0x5B3D210", Offset = "0x5B3BE10", VA = "0x185B3D210")]
			public static int AllocateIndex(RenderChain renderChain)
			{
				return 0;
			}

			// Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012A8")]
			[Address(RVA = "0x5B3D350", Offset = "0x5B3BF50", VA = "0x185B3D350")]
			public static void FreeIndex(int index)
			{
			}

			// Token: 0x060012A9 RID: 4777 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x60012A9")]
			[Address(RVA = "0x5B3D190", Offset = "0x5B3BD90", VA = "0x185B3D190")]
			public static RenderChain AccessIndex(int index)
			{
				return null;
			}

			// Token: 0x040009FB RID: 2555
			[Token(Token = "0x40009FB")]
			[FieldOffset(Offset = "0x0")]
			private static List<RenderChain> renderChains;
		}

		// Token: 0x020002A4 RID: 676
		[Token(Token = "0x20002A4")]
		private struct RenderNodeData
		{
			// Token: 0x040009FC RID: 2556
			[Token(Token = "0x40009FC")]
			[FieldOffset(Offset = "0x0")]
			public Material standardMaterial;

			// Token: 0x040009FD RID: 2557
			[Token(Token = "0x40009FD")]
			[FieldOffset(Offset = "0x8")]
			public Material initialMaterial;

			// Token: 0x040009FE RID: 2558
			[Token(Token = "0x40009FE")]
			[FieldOffset(Offset = "0x10")]
			public MaterialPropertyBlock matPropBlock;

			// Token: 0x040009FF RID: 2559
			[Token(Token = "0x40009FF")]
			[FieldOffset(Offset = "0x18")]
			public RenderChainCommand firstCommand;

			// Token: 0x04000A00 RID: 2560
			[Token(Token = "0x4000A00")]
			[FieldOffset(Offset = "0x20")]
			public UIRenderDevice device;

			// Token: 0x04000A01 RID: 2561
			[Token(Token = "0x4000A01")]
			[FieldOffset(Offset = "0x28")]
			public Texture vectorAtlas;

			// Token: 0x04000A02 RID: 2562
			[Token(Token = "0x4000A02")]
			[FieldOffset(Offset = "0x30")]
			public Texture shaderInfoAtlas;

			// Token: 0x04000A03 RID: 2563
			[Token(Token = "0x4000A03")]
			[FieldOffset(Offset = "0x38")]
			public float dpiScale;

			// Token: 0x04000A04 RID: 2564
			[Token(Token = "0x4000A04")]
			[FieldOffset(Offset = "0x40")]
			public NativeSlice<Transform3x4> transformConstants;

			// Token: 0x04000A05 RID: 2565
			[Token(Token = "0x4000A05")]
			[FieldOffset(Offset = "0x50")]
			public NativeSlice<Vector4> clipRectConstants;
		}
	}
}
