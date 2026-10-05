using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200526E RID: 21102
	[Token(Token = "0x200526E")]
	public class RoguelikeTransitionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x0601F241 RID: 127553 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F242 RID: 127554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048FA")]
		public RoguelikeDungeonState state
		{
			[Token(Token = "0x601F241")]
			[Address(RVA = "0x18EE660", Offset = "0x18ED260", VA = "0x1818EE660")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F242")]
			[Address(RVA = "0x18EE6C0", Offset = "0x18ED2C0", VA = "0x1818EE6C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F243 RID: 127555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F243")]
		[Address(RVA = "0x18EDF30", Offset = "0x18ECB30", VA = "0x1818EDF30")]
		private void _InitIfNot(string topicId)
		{
		}

		// Token: 0x0601F244 RID: 127556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F244")]
		[Address(RVA = "0x18EDFF0", Offset = "0x18ECBF0", VA = "0x1818EDFF0")]
		private void _LoadMainTransControllerIfNot(string topicId)
		{
		}

		// Token: 0x0601F245 RID: 127557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F245")]
		[Address(RVA = "0x18EDD90", Offset = "0x18EC990", VA = "0x1818EDD90")]
		private void _DestroyMainTransView()
		{
		}

		// Token: 0x0601F246 RID: 127558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F246")]
		[Address(RVA = "0x18EDE60", Offset = "0x18ECA60", VA = "0x1818EDE60")]
		private void _DestroySubTransView()
		{
		}

		// Token: 0x0601F247 RID: 127559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F247")]
		[Address(RVA = "0x18EDC70", Offset = "0x18EC870", VA = "0x1818EDC70")]
		public IEnumerator StartShowTransition(RoguelikeDungeonZoneViewProperty property, RoguelikeTransitionView.TransOptions options)
		{
			return null;
		}

		// Token: 0x0601F248 RID: 127560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F248")]
		[Address(RVA = "0x18ED900", Offset = "0x18EC500", VA = "0x1818ED900")]
		public void InterruptShowTransition()
		{
		}

		// Token: 0x0601F249 RID: 127561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F249")]
		[Address(RVA = "0x18EE410", Offset = "0x18ED010", VA = "0x1818EE410")]
		private IEnumerator _ShowMainTransition()
		{
			return null;
		}

		// Token: 0x0601F24A RID: 127562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F24A")]
		[Address(RVA = "0x18EE4C0", Offset = "0x18ED0C0", VA = "0x1818EE4C0")]
		private IEnumerator _ShowSubTransition(RoguelikeTransitionView.SubTransType subTransType, RoguelikeTransitionView.TransOptions transOptions)
		{
			return null;
		}

		// Token: 0x0601F24B RID: 127563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F24B")]
		[Address(RVA = "0x18EE5D0", Offset = "0x18ED1D0", VA = "0x1818EE5D0")]
		public RoguelikeTransitionView()
		{
		}

		// Token: 0x04029C9E RID: 171166
		[Token(Token = "0x4029C9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _mainTransHolder;

		// Token: 0x04029C9F RID: 171167
		[Token(Token = "0x4029C9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("SubTransitions")]
		private Transform _subTransHolder;

		// Token: 0x04029CA0 RID: 171168
		[Token(Token = "0x4029CA0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x04029CA1 RID: 171169
		[Token(Token = "0x4029CA1")]
		[FieldOffset(Offset = "0x30")]
		private string m_topicId;

		// Token: 0x04029CA2 RID: 171170
		[Token(Token = "0x4029CA2")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeMainTransController m_mainTransController;

		// Token: 0x04029CA3 RID: 171171
		[Token(Token = "0x4029CA3")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeSubTransitionPluginContext m_subTransPlugin;

		// Token: 0x04029CA5 RID: 171173
		[Token(Token = "0x4029CA5")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTransitionView.TransController m_transController;

		// Token: 0x04029CA6 RID: 171174
		[Token(Token = "0x4029CA6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x04029CA7 RID: 171175
		[Token(Token = "0x4029CA7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x04029CA8 RID: 171176
		[Token(Token = "0x4029CA8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029CA9 RID: 171177
		[Token(Token = "0x4029CA9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadMainTransControllerIfNot;

		// Token: 0x04029CAA RID: 171178
		[Token(Token = "0x4029CAA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DestroyMainTransView;

		// Token: 0x04029CAB RID: 171179
		[Token(Token = "0x4029CAB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DestroySubTransView;

		// Token: 0x04029CAC RID: 171180
		[Token(Token = "0x4029CAC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_StartShowTransition;

		// Token: 0x04029CAD RID: 171181
		[Token(Token = "0x4029CAD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InterruptShowTransition;

		// Token: 0x04029CAE RID: 171182
		[Token(Token = "0x4029CAE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowMainTransition;

		// Token: 0x04029CAF RID: 171183
		[Token(Token = "0x4029CAF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowSubTransition;

		// Token: 0x04029CB0 RID: 171184
		[Token(Token = "0x4029CB0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200526F RID: 21103
		[Token(Token = "0x200526F")]
		public struct TransOptions
		{
			// Token: 0x04029CB1 RID: 171185
			[Token(Token = "0x4029CB1")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04029CB2 RID: 171186
			[Token(Token = "0x4029CB2")]
			[FieldOffset(Offset = "0x8")]
			public bool isAutoTransition;

			// Token: 0x04029CB3 RID: 171187
			[Token(Token = "0x4029CB3")]
			[FieldOffset(Offset = "0x10")]
			public Action quitTransition;
		}

		// Token: 0x02005270 RID: 21104
		[Token(Token = "0x2005270")]
		public interface ISubTransition : IHotfixable
		{
			// Token: 0x0601F24C RID: 127564
			[Token(Token = "0x601F24C")]
			RoguelikeTransitionView.SubTransType GetTransType();

			// Token: 0x0601F24D RID: 127565
			[Token(Token = "0x601F24D")]
			IEnumerator TransCoroutine();

			// Token: 0x0601F24E RID: 127566
			[Token(Token = "0x601F24E")]
			void Reset();

			// Token: 0x0601F24F RID: 127567
			[Token(Token = "0x601F24F")]
			object DoGetParam(RoguelikeTransitionView.TransOptions transOptions);

			// Token: 0x0601F250 RID: 127568
			[Token(Token = "0x601F250")]
			void DoSetParam(object param);
		}

		// Token: 0x02005271 RID: 21105
		[Token(Token = "0x2005271")]
		public abstract class SubTransitionBase<TParam> : MonoBehaviour, RoguelikeTransitionView.ISubTransition, IHotfixable where TParam : class
		{
			// Token: 0x0601F251 RID: 127569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F251")]
			public object DoGetParam(RoguelikeTransitionView.TransOptions transOptions)
			{
				return null;
			}

			// Token: 0x0601F252 RID: 127570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F252")]
			public void DoSetParam(object param)
			{
			}

			// Token: 0x0601F253 RID: 127571
			[Token(Token = "0x601F253")]
			protected abstract TParam GetParam(RoguelikeTransitionView.TransOptions transOptions);

			// Token: 0x0601F254 RID: 127572
			[Token(Token = "0x601F254")]
			protected abstract void SetParam(TParam param);

			// Token: 0x0601F255 RID: 127573
			[Token(Token = "0x601F255")]
			public abstract RoguelikeTransitionView.SubTransType GetTransType();

			// Token: 0x0601F256 RID: 127574
			[Token(Token = "0x601F256")]
			public abstract IEnumerator TransCoroutine();

			// Token: 0x0601F257 RID: 127575
			[Token(Token = "0x601F257")]
			public abstract void Reset();

			// Token: 0x0601F258 RID: 127576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F258")]
			protected SubTransitionBase()
			{
			}

			// Token: 0x04029CB4 RID: 171188
			[Token(Token = "0x4029CB4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoGetParam;

			// Token: 0x04029CB5 RID: 171189
			[Token(Token = "0x4029CB5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoSetParam;

			// Token: 0x04029CB6 RID: 171190
			[Token(Token = "0x4029CB6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005272 RID: 21106
		[Token(Token = "0x2005272")]
		public enum SubTransType
		{
			// Token: 0x04029CB8 RID: 171192
			[Token(Token = "0x4029CB8")]
			NONE,
			// Token: 0x04029CB9 RID: 171193
			[Token(Token = "0x4029CB9")]
			AVG_CHAT,
			// Token: 0x04029CBA RID: 171194
			[Token(Token = "0x4029CBA")]
			DICE,
			// Token: 0x04029CBB RID: 171195
			[Token(Token = "0x4029CBB")]
			PREDICT,
			// Token: 0x04029CBC RID: 171196
			[Token(Token = "0x4029CBC")]
			EXPEDITION_RETURN,
			// Token: 0x04029CBD RID: 171197
			[Token(Token = "0x4029CBD")]
			DRAW_COPPER
		}

		// Token: 0x02005273 RID: 21107
		[Token(Token = "0x2005273")]
		private class TransController : IHotfixable
		{
			// Token: 0x0601F259 RID: 127577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F259")]
			[Address(RVA = "0x18EF600", Offset = "0x18EE200", VA = "0x1818EF600")]
			public TransController(RoguelikeTransitionView closure)
			{
			}

			// Token: 0x0601F25A RID: 127578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F25A")]
			[Address(RVA = "0x18EF3B0", Offset = "0x18EDFB0", VA = "0x1818EF3B0")]
			public IEnumerable<RoguelikeTransitionView.SubTransType> GetSubTransList()
			{
				return null;
			}

			// Token: 0x0601F25B RID: 127579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F25B")]
			[Address(RVA = "0x18EF460", Offset = "0x18EE060", VA = "0x1818EF460")]
			public object GetSubTransParam(RoguelikeTransitionView.SubTransType type, RoguelikeTransitionView.TransOptions transOptions)
			{
				return null;
			}

			// Token: 0x0601F25C RID: 127580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F25C")]
			[Address(RVA = "0x18EF1C0", Offset = "0x18EDDC0", VA = "0x1818EF1C0")]
			public RoguelikeTransitionView.ISubTransition GetSubTransInst(RoguelikeTransitionView.SubTransType type)
			{
				return null;
			}

			// Token: 0x0601F25D RID: 127581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F25D")]
			[Address(RVA = "0x18EF110", Offset = "0x18EDD10", VA = "0x1818EF110")]
			public IEnumerator<RoguelikeTransitionView.ISubTransition> GetActiveSubTransList()
			{
				return null;
			}

			// Token: 0x04029CBE RID: 171198
			[Token(Token = "0x4029CBE")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeTransitionView m_closure;

			// Token: 0x04029CBF RID: 171199
			[Token(Token = "0x4029CBF")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<RoguelikeTransitionView.SubTransType, RoguelikeTransitionView.ISubTransition> m_prefabMap;

			// Token: 0x04029CC0 RID: 171200
			[Token(Token = "0x4029CC0")]
			[FieldOffset(Offset = "0x20")]
			private ListDict<RoguelikeTransitionView.SubTransType, RoguelikeTransitionView.ISubTransition> m_instMap;

			// Token: 0x04029CC1 RID: 171201
			[Token(Token = "0x4029CC1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029CC2 RID: 171202
			[Token(Token = "0x4029CC2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetSubTransList;

			// Token: 0x04029CC3 RID: 171203
			[Token(Token = "0x4029CC3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetSubTransParam;

			// Token: 0x04029CC4 RID: 171204
			[Token(Token = "0x4029CC4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSubTransInst;

			// Token: 0x04029CC5 RID: 171205
			[Token(Token = "0x4029CC5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetActiveSubTransList;
		}
	}
}
