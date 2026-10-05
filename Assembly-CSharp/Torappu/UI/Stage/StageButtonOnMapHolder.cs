using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006956 RID: 26966
	[Token(Token = "0x2006956")]
	[SelectionBase]
	public class StageButtonOnMapHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005B25 RID: 23333
		// (get) Token: 0x06026998 RID: 158104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B25")]
		public string stageId
		{
			[Token(Token = "0x6026998")]
			[Address(RVA = "0x21A8F80", Offset = "0x21A7B80", VA = "0x1821A8F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005B26 RID: 23334
		// (get) Token: 0x06026999 RID: 158105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B26")]
		protected RectTransform buttonContainer
		{
			[Token(Token = "0x6026999")]
			[Address(RVA = "0x21A8E70", Offset = "0x21A7A70", VA = "0x1821A8E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602699A RID: 158106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602699A")]
		[Address(RVA = "0x21A8560", Offset = "0x21A7160", VA = "0x1821A8560")]
		public void SetButtonContainerActive(bool isActive)
		{
		}

		// Token: 0x0602699B RID: 158107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602699B")]
		[Address(RVA = "0x21A83E0", Offset = "0x21A6FE0", VA = "0x1821A83E0")]
		public void ApplyPatch(StageButtonPatch patch)
		{
		}

		// Token: 0x0602699C RID: 158108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602699C")]
		[Address(RVA = "0x21A8630", Offset = "0x21A7230", VA = "0x1821A8630")]
		public void SetupIfNeeded([Optional] StageButtonOnMap defaultPrefab)
		{
		}

		// Token: 0x0602699D RID: 158109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602699D")]
		[Address(RVA = "0x21A84B0", Offset = "0x21A70B0", VA = "0x1821A84B0")]
		public void Clear()
		{
		}

		// Token: 0x17005B27 RID: 23335
		// (get) Token: 0x0602699E RID: 158110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005B27")]
		public StageButtonOnMap button
		{
			[Token(Token = "0x602699E")]
			[Address(RVA = "0x21A8F20", Offset = "0x21A7B20", VA = "0x1821A8F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602699F RID: 158111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602699F")]
		public TComp SingleComponent<TComp>() where TComp : StageButtonOnMapHolder.SingleComp, new()
		{
			return null;
		}

		// Token: 0x060269A0 RID: 158112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269A0")]
		[Address(RVA = "0x21A88C0", Offset = "0x21A74C0", VA = "0x1821A88C0")]
		public void ZoneMapOnlyOnRenderStage(StageViewModel model)
		{
		}

		// Token: 0x060269A1 RID: 158113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269A1")]
		[Address(RVA = "0x21A8B70", Offset = "0x21A7770", VA = "0x1821A8B70")]
		private void _CollectPlugins()
		{
		}

		// Token: 0x060269A2 RID: 158114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60269A2")]
		[Address(RVA = "0x21A8DC0", Offset = "0x21A79C0", VA = "0x1821A8DC0")]
		public StageButtonOnMapHolder()
		{
		}

		// Token: 0x04036766 RID: 223078
		[Token(Token = "0x4036766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string _stageId;

		// Token: 0x04036767 RID: 223079
		[Token(Token = "0x4036767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageButtonOnMap _prefab;

		// Token: 0x04036768 RID: 223080
		[Token(Token = "0x4036768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("The current transform would be used if this was set to \"None\"")]
		private RectTransform _container;

		// Token: 0x04036769 RID: 223081
		[Token(Token = "0x4036769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ListSet<StageButtonOnMapHolder.IMessageReceiver> m_msgReceivers;

		// Token: 0x0403676A RID: 223082
		[Token(Token = "0x403676A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Type, StageButtonOnMapHolder.SingleComp> m_singleComps;

		// Token: 0x0403676B RID: 223083
		[Token(Token = "0x403676B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private StageButtonOnMap m_button;

		// Token: 0x0403676C RID: 223084
		[Token(Token = "0x403676C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int m_appliedPrefabSign;

		// Token: 0x0403676D RID: 223085
		[Token(Token = "0x403676D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403676E RID: 223086
		[Token(Token = "0x403676E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_buttonContainer;

		// Token: 0x0403676F RID: 223087
		[Token(Token = "0x403676F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetButtonContainerActive;

		// Token: 0x04036770 RID: 223088
		[Token(Token = "0x4036770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyPatch;

		// Token: 0x04036771 RID: 223089
		[Token(Token = "0x4036771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetupIfNeeded;

		// Token: 0x04036772 RID: 223090
		[Token(Token = "0x4036772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04036773 RID: 223091
		[Token(Token = "0x4036773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_button;

		// Token: 0x04036774 RID: 223092
		[Token(Token = "0x4036774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SingleComponent;

		// Token: 0x04036775 RID: 223093
		[Token(Token = "0x4036775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ZoneMapOnlyOnRenderStage;

		// Token: 0x04036776 RID: 223094
		[Token(Token = "0x4036776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CollectPlugins;

		// Token: 0x04036777 RID: 223095
		[Token(Token = "0x4036777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006957 RID: 26967
		[Token(Token = "0x2006957")]
		public interface IMessageReceiver
		{
			// Token: 0x060269A3 RID: 158115
			[Token(Token = "0x60269A3")]
			void OnInit(StageButtonOnMapHolder holder);

			// Token: 0x060269A4 RID: 158116
			[Token(Token = "0x60269A4")]
			void OnRenderStage(StageViewModel model);
		}

		// Token: 0x02006958 RID: 26968
		[Token(Token = "0x2006958")]
		public abstract class SingleComp : IHotfixable
		{
			// Token: 0x060269A5 RID: 158117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60269A5")]
			[Address(RVA = "0x21A7630", Offset = "0x21A6230", VA = "0x1821A7630")]
			protected SingleComp()
			{
			}

			// Token: 0x04036778 RID: 223096
			[Token(Token = "0x4036778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
