using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using Microsoft.Win32;
using GalaSoft.MvvmLight;
using EESSSYSTEM.Domain.Entities;
using EESSSYSTEM.Core;
using EESSSYSTEM.Domain.Usecases;
using ViewModelBase = EESSSYSTEM.Presentation.Pages.MembersPage.MVVM.ViewModelBase;

namespace EESSSYSTEM.Presentation.Pages.MembersPage.MVVM
{
    class MembersPageViewModel : ViewModelBase
    {
        private List<MemberEntity> _memberEntities;
        private ICommand _addTaskCommand;
        private ICommand _initCommand;
        private ICommand _deletedMember;

        public List<MemberEntity> MemberEntities
        {
            get { return _memberEntities; }
            set
            {
                if (_memberEntities != value)
                {
                    _memberEntities = value;
                    OnPropertyChanged(nameof(MemberEntities));
                }
            }
        }

        public ICommand AddTaskCommand
        {
            get
            {
                return _addTaskCommand ?? (_addTaskCommand = new RelayCommand(param => AddMember()));
            }
        }

        public ICommand InitCommand
        {
            get
            {
                return _initCommand ?? (_initCommand = new RelayCommand(param => Init()));
            }
        }

        public ICommand DeletedMemberCommand
        {
            get
            {
                return _deletedMember ?? (_deletedMember = new RelayCommand(param => DeletedMember(param)));
            }
        }

        public MembersPageViewModel()
        {
            MemberEntities = new List<MemberEntity>();
        }

        private void AddMember()
        {
            //MemberEntities.Add(new MemberEntity { TaskName = "Nueva tarea", IsCompleted = false });
        }
        private void DeletedMember(object parameter)
        {
            if (parameter == null) return;
            var member = parameter as MemberEntity;
            MessageBox.Show(member.Name);
        }

        private void Init()
        {
            _ = LoadedDataGridAsync();
        }
        async Task LoadedDataGridAsync()
        {
            var listMembers = await GetMembersAsync();
            MemberEntities.Clear();
            MemberEntities = listMembers;
            MessageBox.Show(MemberEntities.Count.ToString());

        }
        static async Task<List<MemberEntity>> GetMembersAsync()
        {
            var useCase = DependencyInjector.GetInstance<GetAllMembersUseCase>();
            var response = await useCase.Call(new NoParams());
            return response;
        }
    }
}
