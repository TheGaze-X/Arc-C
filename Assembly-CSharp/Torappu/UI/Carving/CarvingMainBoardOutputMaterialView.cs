using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006037 RID: 24631
	[Token(Token = "0x2006037")]
	public class CarvingMainBoardOutputMaterialView : MonoBehaviour, IHotfixable, ITimeWatcher
	{
		// Token: 0x060239DC RID: 145884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239DC")]
		[Address(RVA = "0x1E47800", Offset = "0x1E46400", VA = "0x181E47800")]
		public void Render(CarvingMainViewModel mainModel)
		{
		}

		// Token: 0x060239DD RID: 145885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239DD")]
		[Address(RVA = "0x1E48460", Offset = "0x1E47060", VA = "0x181E48460")]
		private void _RenderNoProcess(CarvingMainBoardOutputMaterialModel model, int enterBoardSeqNum)
		{
		}

		// Token: 0x060239DE RID: 145886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239DE")]
		[Address(RVA = "0x1E47D70", Offset = "0x1E46970", VA = "0x181E47D70")]
		private void _CheckMaterialChanged(List<CarvingMaterialModel> curMaterialList)
		{
		}

		// Token: 0x060239DF RID: 145887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239DF")]
		[Address(RVA = "0x1E483C0", Offset = "0x1E46FC0", VA = "0x181E483C0")]
		private void _PlaySpineAnim()
		{
		}

		// Token: 0x060239E0 RID: 145888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E0")]
		[Address(RVA = "0x1E48320", Offset = "0x1E46F20", VA = "0x181E48320")]
		private void _PlaySpineAnimByLocation(UISpineLocation spineLocation)
		{
		}

		// Token: 0x060239E1 RID: 145889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E1")]
		[Address(RVA = "0x1E485A0", Offset = "0x1E471A0", VA = "0x181E485A0")]
		private void _RenderProcessFrame(CarvingMainProcessModel model)
		{
		}

		// Token: 0x060239E2 RID: 145890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E2")]
		[Address(RVA = "0x1E480E0", Offset = "0x1E46CE0", VA = "0x181E480E0")]
		private void _PlayPointChange(int point)
		{
		}

		// Token: 0x060239E3 RID: 145891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E3")]
		[Address(RVA = "0x1E486F0", Offset = "0x1E472F0", VA = "0x181E486F0")]
		private void _RenderText(int curPoint)
		{
		}

		// Token: 0x060239E4 RID: 145892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E4")]
		[Address(RVA = "0x1E47F30", Offset = "0x1E46B30", VA = "0x181E47F30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060239E5 RID: 145893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E5")]
		[Address(RVA = "0x1E47CC0", Offset = "0x1E468C0", VA = "0x181E47CC0", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x060239E6 RID: 145894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E6")]
		[Address(RVA = "0x1E47C60", Offset = "0x1E46860", VA = "0x181E47C60")]
		private void Start()
		{
		}

		// Token: 0x060239E7 RID: 145895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E7")]
		[Address(RVA = "0x1E477A0", Offset = "0x1E463A0", VA = "0x181E477A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060239E8 RID: 145896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60239E8")]
		[Address(RVA = "0x1E489D0", Offset = "0x1E475D0", VA = "0x181E489D0")]
		public CarvingMainBoardOutputMaterialView()
		{
		}

		// Token: 0x04031508 RID: 201992
		[Token(Token = "0x4031508")]
		private const string EMPTY_DIGIT = "0";

		// Token: 0x04031509 RID: 201993
		[Token(Token = "0x4031509")]
		private const int MAX_SCORE = 9999999;

		// Token: 0x0403150A RID: 201994
		[Token(Token = "0x403150A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _materialContent;

		// Token: 0x0403150B RID: 201995
		[Token(Token = "0x403150B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Text> _outputPoint;

		// Token: 0x0403150C RID: 201996
		[Token(Token = "0x403150C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _emptyColor;

		// Token: 0x0403150D RID: 201997
		[Token(Token = "0x403150D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _numColor;

		// Token: 0x0403150E RID: 201998
		[Token(Token = "0x403150E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _txtTweenDuration;

		// Token: 0x0403150F RID: 201999
		[Token(Token = "0x403150F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UISpineLocation _sleepLocation;

		// Token: 0x04031510 RID: 202000
		[Token(Token = "0x4031510")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UISpineLocation _normalLocation;

		// Token: 0x04031511 RID: 202001
		[Token(Token = "0x4031511")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UISpineLocation _happyLocation;

		// Token: 0x04031512 RID: 202002
		[Token(Token = "0x4031512")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _contentCanvasGroup;

		// Token: 0x04031513 RID: 202003
		[Token(Token = "0x4031513")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _spineStateChangeDelay;

		// Token: 0x04031514 RID: 202004
		[Token(Token = "0x4031514")]
		[FieldOffset(Offset = "0x90")]
		private CarvingMainBoardOutputMaterialView.MaterialAdapter m_materialAdapter;

		// Token: 0x04031515 RID: 202005
		[Token(Token = "0x4031515")]
		[FieldOffset(Offset = "0x98")]
		private List<CarvingMaterialModel> m_cachedMaterialItemList;

		// Token: 0x04031516 RID: 202006
		[Token(Token = "0x4031516")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04031517 RID: 202007
		[Token(Token = "0x4031517")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_hasMaterialChanged;

		// Token: 0x04031518 RID: 202008
		[Token(Token = "0x4031518")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_pointChangeTween;

		// Token: 0x04031519 RID: 202009
		[Token(Token = "0x4031519")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_materialContentTween;

		// Token: 0x0403151A RID: 202010
		[Token(Token = "0x403151A")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedPoint;

		// Token: 0x0403151B RID: 202011
		[Token(Token = "0x403151B")]
		[FieldOffset(Offset = "0xBC")]
		private CarvingMainBoardOutputMaterialModel.BirdSpineState m_cachedWaitingState;

		// Token: 0x0403151C RID: 202012
		[Token(Token = "0x403151C")]
		[FieldOffset(Offset = "0xC0")]
		private CarvingMainBoardOutputMaterialModel.BirdSpineState m_cachedPlayingState;

		// Token: 0x0403151D RID: 202013
		[Token(Token = "0x403151D")]
		[FieldOffset(Offset = "0xC4")]
		private float m_cachedDelay;

		// Token: 0x0403151E RID: 202014
		[Token(Token = "0x403151E")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isChanged;

		// Token: 0x0403151F RID: 202015
		[Token(Token = "0x403151F")]
		[FieldOffset(Offset = "0xCC")]
		private int m_cachedEnterBoardSeqNum;

		// Token: 0x04031520 RID: 202016
		[Token(Token = "0x4031520")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031521 RID: 202017
		[Token(Token = "0x4031521")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderNoProcess;

		// Token: 0x04031522 RID: 202018
		[Token(Token = "0x4031522")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckMaterialChanged;

		// Token: 0x04031523 RID: 202019
		[Token(Token = "0x4031523")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlaySpineAnim;

		// Token: 0x04031524 RID: 202020
		[Token(Token = "0x4031524")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlaySpineAnimByLocation;

		// Token: 0x04031525 RID: 202021
		[Token(Token = "0x4031525")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderProcessFrame;

		// Token: 0x04031526 RID: 202022
		[Token(Token = "0x4031526")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayPointChange;

		// Token: 0x04031527 RID: 202023
		[Token(Token = "0x4031527")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderText;

		// Token: 0x04031528 RID: 202024
		[Token(Token = "0x4031528")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031529 RID: 202025
		[Token(Token = "0x4031529")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0403152A RID: 202026
		[Token(Token = "0x403152A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0403152B RID: 202027
		[Token(Token = "0x403152B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403152C RID: 202028
		[Token(Token = "0x403152C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006038 RID: 24632
		[Token(Token = "0x2006038")]
		private class MaterialAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005418 RID: 21528
			// (get) Token: 0x060239E9 RID: 145897 RVA: 0x000C15D8 File Offset: 0x000BF7D8
			[Token(Token = "0x17005418")]
			public override int count
			{
				[Token(Token = "0x60239E9")]
				[Address(RVA = "0x1E53CE0", Offset = "0x1E528E0", VA = "0x181E53CE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060239EA RID: 145898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60239EA")]
			[Address(RVA = "0x1E53C60", Offset = "0x1E52860", VA = "0x181E53C60")]
			public MaterialAdapter(CarvingMainBoardOutputMaterialView closure)
			{
			}

			// Token: 0x060239EB RID: 145899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60239EB")]
			[Address(RVA = "0x1E53A60", Offset = "0x1E52660", VA = "0x181E53A60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403152D RID: 202029
			[Token(Token = "0x403152D")]
			[FieldOffset(Offset = "0x20")]
			private CarvingMainBoardOutputMaterialView m_closure;

			// Token: 0x0403152E RID: 202030
			[Token(Token = "0x403152E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403152F RID: 202031
			[Token(Token = "0x403152F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031530 RID: 202032
			[Token(Token = "0x4031530")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
