using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x0200199F RID: 6559
	[Token(Token = "0x200199F")]
	public class DIYPresetPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x0003FF00 File Offset: 0x0003E100
		[Token(Token = "0x17001309")]
		public bool shown
		{
			[Token(Token = "0x600A4BB")]
			[Address(RVA = "0x31F4380", Offset = "0x31F2F80", VA = "0x1831F4380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A4BC RID: 42172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4BC")]
		[Address(RVA = "0x31F3810", Offset = "0x31F2410", VA = "0x1831F3810")]
		private Action<Texture2D> _GetTextureFetchCallback(int index, DIYPresetPanel.PresetViewData presetData, DIYFurnitureScrollAdapter adapter)
		{
			return null;
		}

		// Token: 0x0600A4BD RID: 42173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4BD")]
		[Address(RVA = "0x31F3930", Offset = "0x31F2530", VA = "0x1831F3930")]
		private Action _GetTextureFetchFailedCallback(int index, DIYPresetPanel.PresetViewData presetData)
		{
			return null;
		}

		// Token: 0x0600A4BE RID: 42174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4BE")]
		[Address(RVA = "0x31F3720", Offset = "0x31F2320", VA = "0x1831F3720")]
		private void Update()
		{
		}

		// Token: 0x0600A4BF RID: 42175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4BF")]
		[Address(RVA = "0x31F3620", Offset = "0x31F2220", VA = "0x1831F3620")]
		public void Setup(DIYPresetPanel.Params param, Action<int, string> renameCallback, Action<int, IDIYPreset> loadCallback, Action saveCallback)
		{
		}

		// Token: 0x0600A4C0 RID: 42176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4C0")]
		[Address(RVA = "0x31F2B50", Offset = "0x31F1750", VA = "0x1831F2B50")]
		public void Render(DIYPresetPanel.Params param)
		{
		}

		// Token: 0x0600A4C1 RID: 42177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4C1")]
		[Address(RVA = "0x31F3D30", Offset = "0x31F2930", VA = "0x1831F3D30")]
		private void _SelectPreset(int index)
		{
		}

		// Token: 0x0600A4C2 RID: 42178 RVA: 0x0003FF18 File Offset: 0x0003E118
		[Token(Token = "0x600A4C2")]
		[Address(RVA = "0x31F3A60", Offset = "0x31F2660", VA = "0x1831F3A60")]
		private bool _OnPresetSelected(DIYItemViewData data)
		{
			return default(bool);
		}

		// Token: 0x0600A4C3 RID: 42179 RVA: 0x0003FF30 File Offset: 0x0003E130
		[Token(Token = "0x600A4C3")]
		[Address(RVA = "0x31F3BC0", Offset = "0x31F27C0", VA = "0x1831F3BC0")]
		private bool _OnRenameButtonPressed(DIYItemViewData data)
		{
			return default(bool);
		}

		// Token: 0x0600A4C4 RID: 42180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4C4")]
		[Address(RVA = "0x31F4070", Offset = "0x31F2C70", VA = "0x1831F4070")]
		private void _SetPresetTitleText()
		{
		}

		// Token: 0x0600A4C5 RID: 42181 RVA: 0x0003FF48 File Offset: 0x0003E148
		[Token(Token = "0x600A4C5")]
		[Address(RVA = "0x31F2A20", Offset = "0x31F1620", VA = "0x1831F2A20")]
		public int GetCurrentIndex()
		{
			return 0;
		}

		// Token: 0x0600A4C6 RID: 42182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A4C6")]
		[Address(RVA = "0x31F2AF0", Offset = "0x31F16F0", VA = "0x1831F2AF0")]
		public IDIYPreset GetCurrentPreset()
		{
			return null;
		}

		// Token: 0x0600A4C7 RID: 42183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4C7")]
		[Address(RVA = "0x31F42C0", Offset = "0x31F2EC0", VA = "0x1831F42C0")]
		public DIYPresetPanel()
		{
		}

		// Token: 0x04009C00 RID: 39936
		[Token(Token = "0x4009C00")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYFurnitureScrollAdapter _adapter;

		// Token: 0x04009C01 RID: 39937
		[Token(Token = "0x4009C01")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _emptyPresetIcon;

		// Token: 0x04009C02 RID: 39938
		[Token(Token = "0x4009C02")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _loadButton;

		// Token: 0x04009C03 RID: 39939
		[Token(Token = "0x4009C03")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _saveButton;

		// Token: 0x04009C04 RID: 39940
		[Token(Token = "0x4009C04")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite _presetIconInvalid;

		// Token: 0x04009C05 RID: 39941
		[Token(Token = "0x4009C05")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite _presetIconLoading;

		// Token: 0x04009C06 RID: 39942
		[Token(Token = "0x4009C06")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _presetTitle;

		// Token: 0x04009C07 RID: 39943
		[Token(Token = "0x4009C07")]
		[FieldOffset(Offset = "0x50")]
		private IDIYPreset m_currentDIYPreset;

		// Token: 0x04009C08 RID: 39944
		[Token(Token = "0x4009C08")]
		[FieldOffset(Offset = "0x58")]
		private int m_currentIndex;

		// Token: 0x04009C09 RID: 39945
		[Token(Token = "0x4009C09")]
		[FieldOffset(Offset = "0x60")]
		private IDIYPresetManager m_presetManager;

		// Token: 0x04009C0A RID: 39946
		[Token(Token = "0x4009C0A")]
		[FieldOffset(Offset = "0x68")]
		private Action<int, string> m_presetRenameCallback;

		// Token: 0x04009C0B RID: 39947
		[Token(Token = "0x4009C0B")]
		[FieldOffset(Offset = "0x70")]
		private Action<int, IDIYPreset> m_presetLoadCallback;

		// Token: 0x04009C0C RID: 39948
		[Token(Token = "0x4009C0C")]
		[FieldOffset(Offset = "0x78")]
		private Action m_presetSaveCallback;

		// Token: 0x04009C0D RID: 39949
		[Token(Token = "0x4009C0D")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_currentTween;

		// Token: 0x04009C0E RID: 39950
		[Token(Token = "0x4009C0E")]
		[FieldOffset(Offset = "0x88")]
		private bool m_shown;

		// Token: 0x04009C0F RID: 39951
		[Token(Token = "0x4009C0F")]
		[FieldOffset(Offset = "0x90")]
		private List<IEnumerator> m_coroutines;

		// Token: 0x04009C10 RID: 39952
		[Token(Token = "0x4009C10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_shown;

		// Token: 0x04009C11 RID: 39953
		[Token(Token = "0x4009C11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetTextureFetchCallback;

		// Token: 0x04009C12 RID: 39954
		[Token(Token = "0x4009C12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetTextureFetchFailedCallback;

		// Token: 0x04009C13 RID: 39955
		[Token(Token = "0x4009C13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04009C14 RID: 39956
		[Token(Token = "0x4009C14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009C15 RID: 39957
		[Token(Token = "0x4009C15")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04009C16 RID: 39958
		[Token(Token = "0x4009C16")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SelectPreset;

		// Token: 0x04009C17 RID: 39959
		[Token(Token = "0x4009C17")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnPresetSelected;

		// Token: 0x04009C18 RID: 39960
		[Token(Token = "0x4009C18")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnRenameButtonPressed;

		// Token: 0x04009C19 RID: 39961
		[Token(Token = "0x4009C19")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetPresetTitleText;

		// Token: 0x04009C1A RID: 39962
		[Token(Token = "0x4009C1A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCurrentIndex;

		// Token: 0x04009C1B RID: 39963
		[Token(Token = "0x4009C1B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetCurrentPreset;

		// Token: 0x04009C1C RID: 39964
		[Token(Token = "0x4009C1C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020019A0 RID: 6560
		[Token(Token = "0x20019A0")]
		public struct Params
		{
			// Token: 0x04009C1D RID: 39965
			[Token(Token = "0x4009C1D")]
			[FieldOffset(Offset = "0x0")]
			public PersistentImageProxy imageProxy;

			// Token: 0x04009C1E RID: 39966
			[Token(Token = "0x4009C1E")]
			[FieldOffset(Offset = "0x8")]
			public string imageBasePath;

			// Token: 0x04009C1F RID: 39967
			[Token(Token = "0x4009C1F")]
			[FieldOffset(Offset = "0x10")]
			public IDIYPresetManager manager;
		}

		// Token: 0x020019A1 RID: 6561
		[Token(Token = "0x20019A1")]
		private class PresetViewData : DIYItemViewData
		{
			// Token: 0x0600A4C8 RID: 42184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4C8")]
			[Address(RVA = "0x31FEFF0", Offset = "0x31FDBF0", VA = "0x1831FEFF0", Slot = "22")]
			public override string GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A4C9 RID: 42185 RVA: 0x0003FF60 File Offset: 0x0003E160
			[Token(Token = "0x600A4C9")]
			[Address(RVA = "0x31FF1C0", Offset = "0x31FDDC0", VA = "0x1831FF1C0", Slot = "10")]
			public override bool ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600A4CA RID: 42186 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4CA")]
			[Address(RVA = "0x31FE8F0", Offset = "0x31FD4F0", VA = "0x1831FE8F0", Slot = "4")]
			public override Sprite GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A4CB RID: 42187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4CB")]
			[Address(RVA = "0x31FF090", Offset = "0x31FDC90", VA = "0x1831FF090", Slot = "5")]
			public override Sprite GetSmallSprite()
			{
				return null;
			}

			// Token: 0x0600A4CC RID: 42188 RVA: 0x0003FF78 File Offset: 0x0003E178
			[Token(Token = "0x600A4CC")]
			[Address(RVA = "0x31FF280", Offset = "0x31FDE80", VA = "0x1831FF280", Slot = "13")]
			public override bool ShowSubButton()
			{
				return default(bool);
			}

			// Token: 0x0600A4CD RID: 42189 RVA: 0x0003FF90 File Offset: 0x0003E190
			[Token(Token = "0x600A4CD")]
			[Address(RVA = "0x31FF220", Offset = "0x31FDE20", VA = "0x1831FF220", Slot = "15")]
			public override bool ShowRenameButton()
			{
				return default(bool);
			}

			// Token: 0x0600A4CE RID: 42190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4CE")]
			[Address(RVA = "0x31FF380", Offset = "0x31FDF80", VA = "0x1831FF380", Slot = "25")]
			public override void Uninitialize()
			{
			}

			// Token: 0x0600A4CF RID: 42191 RVA: 0x0003FFA8 File Offset: 0x0003E1A8
			[Token(Token = "0x600A4CF")]
			[Address(RVA = "0x31FF160", Offset = "0x31FDD60", VA = "0x1831FF160", Slot = "17")]
			public override bool ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600A4D0 RID: 42192 RVA: 0x0003FFC0 File Offset: 0x0003E1C0
			[Token(Token = "0x600A4D0")]
			[Address(RVA = "0x31FE960", Offset = "0x31FD560", VA = "0x1831FE960", Slot = "18")]
			public override int GetComfort()
			{
				return 0;
			}

			// Token: 0x0600A4D1 RID: 42193 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
			[Token(Token = "0x600A4D1")]
			[Address(RVA = "0x31FF100", Offset = "0x31FDD00", VA = "0x1831FF100", Slot = "26")]
			public override bool Selected()
			{
				return default(bool);
			}

			// Token: 0x0600A4D2 RID: 42194 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4D2")]
			[Address(RVA = "0x31FF460", Offset = "0x31FE060", VA = "0x1831FF460")]
			public PresetViewData()
			{
			}

			// Token: 0x0600A4D3 RID: 42195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4D3")]
			[Address(RVA = "0x31FF300", Offset = "0x31FDF00", VA = "0x1831FF300")]
			private string <>xLuaBaseProxy_GetDisplayName()
			{
				return null;
			}

			// Token: 0x0600A4D4 RID: 42196 RVA: 0x0003FFF0 File Offset: 0x0003E1F0
			[Token(Token = "0x600A4D4")]
			[Address(RVA = "0x31FF340", Offset = "0x31FDF40", VA = "0x1831FF340")]
			private bool <>xLuaBaseProxy_ShowCount()
			{
				return default(bool);
			}

			// Token: 0x0600A4D5 RID: 42197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4D5")]
			[Address(RVA = "0x31FF2E0", Offset = "0x31FDEE0", VA = "0x1831FF2E0")]
			private Sprite <>xLuaBaseProxy_GetBigSprite()
			{
				return null;
			}

			// Token: 0x0600A4D6 RID: 42198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A4D6")]
			[Address(RVA = "0x31FF310", Offset = "0x31FDF10", VA = "0x1831FF310")]
			private Sprite <>xLuaBaseProxy_GetSmallSprite()
			{
				return null;
			}

			// Token: 0x0600A4D7 RID: 42199 RVA: 0x00040008 File Offset: 0x0003E208
			[Token(Token = "0x600A4D7")]
			[Address(RVA = "0x31FF360", Offset = "0x31FDF60", VA = "0x1831FF360")]
			private bool <>xLuaBaseProxy_ShowSubButton()
			{
				return default(bool);
			}

			// Token: 0x0600A4D8 RID: 42200 RVA: 0x00040020 File Offset: 0x0003E220
			[Token(Token = "0x600A4D8")]
			[Address(RVA = "0x31FF350", Offset = "0x31FDF50", VA = "0x1831FF350")]
			private bool <>xLuaBaseProxy_ShowRenameButton()
			{
				return default(bool);
			}

			// Token: 0x0600A4D9 RID: 42201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A4D9")]
			[Address(RVA = "0x31FF370", Offset = "0x31FDF70", VA = "0x1831FF370")]
			private void <>xLuaBaseProxy_Uninitialize()
			{
			}

			// Token: 0x0600A4DA RID: 42202 RVA: 0x00040038 File Offset: 0x0003E238
			[Token(Token = "0x600A4DA")]
			[Address(RVA = "0x31FF330", Offset = "0x31FDF30", VA = "0x1831FF330")]
			private bool <>xLuaBaseProxy_ShowComfort()
			{
				return default(bool);
			}

			// Token: 0x0600A4DB RID: 42203 RVA: 0x00040050 File Offset: 0x0003E250
			[Token(Token = "0x600A4DB")]
			[Address(RVA = "0x31FF2F0", Offset = "0x31FDEF0", VA = "0x1831FF2F0")]
			private int <>xLuaBaseProxy_GetComfort()
			{
				return 0;
			}

			// Token: 0x0600A4DC RID: 42204 RVA: 0x00040068 File Offset: 0x0003E268
			[Token(Token = "0x600A4DC")]
			[Address(RVA = "0x31FF320", Offset = "0x31FDF20", VA = "0x1831FF320")]
			private bool <>xLuaBaseProxy_Selected()
			{
				return default(bool);
			}

			// Token: 0x04009C20 RID: 39968
			[Token(Token = "0x4009C20")]
			[FieldOffset(Offset = "0x38")]
			public int index;

			// Token: 0x04009C21 RID: 39969
			[Token(Token = "0x4009C21")]
			[FieldOffset(Offset = "0x40")]
			public IDIYPreset preset;

			// Token: 0x04009C22 RID: 39970
			[Token(Token = "0x4009C22")]
			[FieldOffset(Offset = "0x48")]
			public Sprite emptyIcon;

			// Token: 0x04009C23 RID: 39971
			[Token(Token = "0x4009C23")]
			[FieldOffset(Offset = "0x50")]
			public bool selected;

			// Token: 0x04009C24 RID: 39972
			[Token(Token = "0x4009C24")]
			[FieldOffset(Offset = "0x58")]
			public Sprite imageSpriteCached;

			// Token: 0x04009C25 RID: 39973
			[Token(Token = "0x4009C25")]
			[FieldOffset(Offset = "0x60")]
			public bool spriteNeedDestroy;

			// Token: 0x04009C26 RID: 39974
			[Token(Token = "0x4009C26")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDisplayName;

			// Token: 0x04009C27 RID: 39975
			[Token(Token = "0x4009C27")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ShowCount;

			// Token: 0x04009C28 RID: 39976
			[Token(Token = "0x4009C28")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetBigSprite;

			// Token: 0x04009C29 RID: 39977
			[Token(Token = "0x4009C29")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetSmallSprite;

			// Token: 0x04009C2A RID: 39978
			[Token(Token = "0x4009C2A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ShowSubButton;

			// Token: 0x04009C2B RID: 39979
			[Token(Token = "0x4009C2B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ShowRenameButton;

			// Token: 0x04009C2C RID: 39980
			[Token(Token = "0x4009C2C")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_Uninitialize;

			// Token: 0x04009C2D RID: 39981
			[Token(Token = "0x4009C2D")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ShowComfort;

			// Token: 0x04009C2E RID: 39982
			[Token(Token = "0x4009C2E")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GetComfort;

			// Token: 0x04009C2F RID: 39983
			[Token(Token = "0x4009C2F")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Selected;

			// Token: 0x04009C30 RID: 39984
			[Token(Token = "0x4009C30")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020019A2 RID: 6562
			[Token(Token = "0x20019A2")]
			private class InnerFurnitureProvider : IFurnitureProvider
			{
				// Token: 0x0600A4DD RID: 42205 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4DD")]
				[Address(RVA = "0x31FE410", Offset = "0x31FD010", VA = "0x1831FE410", Slot = "4")]
				public void QueryData(Predicate<Furniture> filter, Action<Furniture> action)
				{
				}

				// Token: 0x0600A4DE RID: 42206 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4DE")]
				[Address(RVA = "0x31FE500", Offset = "0x31FD100", VA = "0x1831FE500", Slot = "5")]
				public void QueryDatas(Predicate<Furniture> filter, Action<Furniture> action)
				{
				}

				// Token: 0x0600A4DF RID: 42207 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4DF")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
				public void RegisterListener(IFurnitureProviderListener listener)
				{
				}

				// Token: 0x0600A4E0 RID: 42208 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4E0")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
				public void UnregisterListener(IFurnitureProviderListener listener)
				{
				}

				// Token: 0x0600A4E1 RID: 42209 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4E1")]
				[Address(RVA = "0x31FE5F0", Offset = "0x31FD1F0", VA = "0x1831FE5F0")]
				public InnerFurnitureProvider()
				{
				}

				// Token: 0x04009C31 RID: 39985
				[Token(Token = "0x4009C31")]
				[FieldOffset(Offset = "0x10")]
				public List<Furniture> furnitureList;
			}

			// Token: 0x020019A3 RID: 6563
			[Token(Token = "0x20019A3")]
			private class InnerModifierProvider : IDIYRoomModifierProvider
			{
				// Token: 0x0600A4E2 RID: 42210 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4E2")]
				[Address(RVA = "0x31FE680", Offset = "0x31FD280", VA = "0x1831FE680", Slot = "4")]
				public void QueryData(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
				{
				}

				// Token: 0x0600A4E3 RID: 42211 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4E3")]
				[Address(RVA = "0x31FE770", Offset = "0x31FD370", VA = "0x1831FE770", Slot = "5")]
				public void QueryDatas(Predicate<DIYRoomModifier> filter, Action<DIYRoomModifier> action)
				{
				}

				// Token: 0x0600A4E4 RID: 42212 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4E4")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
				public void RegisterListener(IDIYRoomModifierProviderListener listener)
				{
				}

				// Token: 0x0600A4E5 RID: 42213 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4E5")]
				[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
				public void UnregisterListener(IDIYRoomModifierProviderListener listener)
				{
				}

				// Token: 0x0600A4E6 RID: 42214 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600A4E6")]
				[Address(RVA = "0x31FE860", Offset = "0x31FD460", VA = "0x1831FE860")]
				public InnerModifierProvider()
				{
				}

				// Token: 0x04009C32 RID: 39986
				[Token(Token = "0x4009C32")]
				[FieldOffset(Offset = "0x10")]
				public List<DIYRoomModifier> modifierList;
			}
		}
	}
}
