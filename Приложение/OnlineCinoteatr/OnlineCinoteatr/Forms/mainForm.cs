using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OnlineCinoteatr.Model;
using System.Data.SqlClient;
using OnlineCinoteatr.Forms.Films;
using OnlineCinoteatr.Forms.ZhanrForms;
using OnlineCinoteatr.Forms.ActorForms;
using OnlineCinoteatr.Forms.BuilderForms;
using OnlineCinoteatr.Forms.PodpiskaForms;
using OnlineCinoteatr.Forms.UserForms;
using OnlineCinoteatr.Forms.ViewsUsersForms;
using OnlineCinoteatr.Forms.Функции;

namespace OnlineCinoteatr.Forms
{
    public partial class mainForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private AuthorizationForm authorizationForm;

        DataSet ds = null;
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();

        public int filmId = -1;
        public int zhanrId = -1;
        public int actorId = -1;
        public int buildId = -1;
        public int podId = -1;
        public int userId = -1;
        public int viewId = -1;

        public mainForm()
        {
            InitializeComponent();
        }

        public mainForm(string connectionString, AuthorizationForm authorizationForm)
        {
            this.connectionString = connectionString;
            this.authorizationForm = authorizationForm;
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public string stateRole = "";
        public void HideButtonUser()
        {
            this.Size = new Size(1065, 496);
            MainGridView.Size = new Size(742, 306);
            zhanrGridView.Size = new Size(742, 306);
            zhanrFGridView.Size = new Size(742, 306);
            actGridView.Size = new Size(742, 306);
            actFGridView.Size = new Size(742, 306);
            podGridView.Size = new Size(742, 306);
            poduserGridView.Size = new Size(742, 306);
            buildGridView.Size = new Size(742, 306);
            buildFGridView.Size = new Size(742, 306);
            viewGridView.Size = new Size(742, 306);
            delusersGridView.Size = new Size(742, 306);
            dataGridGlView.Size = new Size(742, 306);

            stateRole = "Client";

            viewsBut.Visible = false;
            userBut.Visible = false;
            zhanrFBut.Visible = false;
            actFBut.Visible = false;
            buildFBut.Visible = false;
            podUBut.Visible = false;
            deluserBut.Visible = false;

            hranimBut.Visible = false;
            scalBut.Visible = false;
            predBut.Visible = false;
            updateBut.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            authregForm authregForm = new authregForm();
            authregForm.Show();
            this.Hide();
            return;
        }

        // начало Фильмы
        private void filmBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = false;
            MainGridView.Visible = true;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            showFilm();
        }

        public void showFilm()
        {
            using (Context db = new Context(connectionString))
            {
                MainGridView.DataSource = db.Database.SqlQuery<Film>("SELECT * FROM Film").ToList();

                MainGridView.Columns["ID_Filma"].Visible = false;
                MainGridView.Columns["FilmName"].HeaderText = "Название";
                MainGridView.Columns["DataVihoda"].HeaderText = "Дата выхода";
                MainGridView.Columns["Country"].HeaderText = "Страна";
                MainGridView.Columns["AgeRestriction"].HeaderText = "Возрастное ограничение";
                MainGridView.Columns["FilmDescription"].HeaderText = "Описание";
                MainGridView.Columns["Repertuar"].HeaderText = "Репертуар";

                MainGridView.Columns.Remove("FilmActors");
                MainGridView.Columns.Remove("FilmBuilders");
                MainGridView.Columns.Remove("FilmZhanrs");
                MainGridView.Columns.Remove("ViewsFilmsUsers");
            }
        }

        public void MainGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = MainGridView.HitTest(e.X, e.Y).RowIndex;
                if (stateRole != "Client")
                {
                    m.MenuItems.Add(new MenuItem("Добавить новый фильм", AddNewFilm));

                    if (currentMouseOverRow >= 0)
                    {
                        using (Context db = new Context(connectionString))
                            filmId = (int)MainGridView.Rows[currentMouseOverRow].Cells["ID_Filma"].Value;

                        m.MenuItems.Add(new MenuItem("Изменить", UpdateFilm));
                        m.MenuItems.Add(new MenuItem("Удалить", DeleteFilm));
                    }
                }

                m.Show(MainGridView, new Point(e.X, e.Y));
            }
        }

        private void AddNewFilm(object sender, EventArgs e)
        {
            new AddFilms(connectionString, this).ShowDialog();
        }

        private void UpdateFilm(object sender, EventArgs e)
        {
            new UpdateFilm(connectionString, filmId, this).ShowDialog();
        }

        private void DeleteFilm(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Context db = new Context(connectionString))
                {
                    db.Films.Remove(db.Films.Find(filmId));
                    db.SaveChanges();
                }
            }
            else
            {
                return;
            }

            showFilm();

        }

        private void MainGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // конец Фильмы

        // Начало Жанр

        private void zhanrBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = true;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = false;
            MainGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = false;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            showZhanr();
        }

        public void showZhanr()
        {
            using (Context db = new Context(connectionString))
            {
                zhanrGridView.DataSource = db.Database.SqlQuery<Zhanr>("SELECT * FROM Zhanr").ToList();

                zhanrGridView.Columns["ID_Zhanra"].Visible = false;
                zhanrGridView.Columns["ZhanrName"].HeaderText = "Название жанра";
                zhanrGridView.Columns.Remove("FilmZhanrs");
            }
        }

        private void zhanrGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = zhanrGridView.HitTest(e.X, e.Y).RowIndex;
                if (stateRole != "Client")
                {
                    m.MenuItems.Add(new MenuItem("Добавить новый жанр", AddNewZhanr));

                    if (currentMouseOverRow >= 0)
                    {
                        using (Context db = new Context(connectionString))
                            zhanrId = (int)zhanrGridView.Rows[currentMouseOverRow].Cells["ID_Zhanra"].Value;

                        m.MenuItems.Add(new MenuItem("Изменить", UpdateZhanr));
                        m.MenuItems.Add(new MenuItem("Удалить", DeleteZhanr));
                    }
                }

                m.Show(zhanrGridView, new Point(e.X, e.Y));
            }
        }

        private void AddNewZhanr(object sender, EventArgs e)
        {
            new AddNewZhanr(connectionString, this).ShowDialog();
        }
        private void UpdateZhanr(object sender, EventArgs e)
        {
            new UpdateZhanr(connectionString, zhanrId, this).ShowDialog();
        }
        private void DeleteZhanr(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Context db = new Context(connectionString))
                {
                    db.Zhanrs.Remove(db.Zhanrs.Find(zhanrId));
                    db.SaveChanges();
                }
            }
            else
            {
                return;
            }

            showZhanr();
        }

        // конец Жанр

        // начало Актёров

        public void showActors()
        {
            using (Context db = new Context(connectionString))
            {
                actGridView.DataSource = db.Database.SqlQuery<Actor>("SELECT * FROM Actor").ToList();

                actGridView.Columns["ID_Actor"].Visible = false;
                actGridView.Columns["Surname"].HeaderText = "Фамилия";
                actGridView.Columns["FirstName"].HeaderText = "Имя";
                actGridView.Columns["MiddleName"].HeaderText = "Отчество";
                actGridView.Columns["KolichestvoFilmov"].HeaderText = "Количество фильмов";
                actGridView.Columns["Birthday"].HeaderText = "Дата рождения";

                actGridView.Columns.Remove("FilmActors");
            }
        }

        private void actBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = true;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = false;
            MainGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = false;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            showActors();
        }

        private void actGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = actGridView.HitTest(e.X, e.Y).RowIndex;
                if (stateRole != "Client")
                {
                    m.MenuItems.Add(new MenuItem("Добавить актёра", AddNewActor));

                    if (currentMouseOverRow >= 0)
                    {
                        using (Context db = new Context(connectionString))
                            actorId = (int)actGridView.Rows[currentMouseOverRow].Cells["ID_Actor"].Value;

                        m.MenuItems.Add(new MenuItem("Изменить", UpdateActor));
                        m.MenuItems.Add(new MenuItem("Удалить", DeleteActor));
                    }
                }

                m.Show(actGridView, new Point(e.X, e.Y));
            }
        }

        public void AddNewActor(object sender, EventArgs e)
        {
            new AddNewActor(connectionString, this).ShowDialog();
        }

        public void UpdateActor(object sender, EventArgs e)
        {
            new UpdateActors(connectionString, actorId, this).ShowDialog();
        }
        public void DeleteActor(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Context db = new Context(connectionString))
                {
                    db.Actors.Remove(db.Actors.Find(actorId));
                    db.SaveChanges();
                }
            }
            else
            {
                return;
            }

            showActors();
        }
        // конец Актёров

        // начало Создателей
        private void buildBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = true;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = false;
            MainGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = false;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            showBuilders();
        }

        public void showBuilders()
        {
            using (Context db = new Context(connectionString))
            {
                buildGridView.DataSource = db.Database.SqlQuery<Builder>("SELECT * FROM Builder").ToList();

                buildGridView.Columns["ID_Builder"].Visible = false;
                buildGridView.Columns["Surname"].HeaderText = "Фамилия";
                buildGridView.Columns["FirstName"].HeaderText = "Имя";
                buildGridView.Columns["MiddleName"].HeaderText = "Отчество";
                buildGridView.Columns["KolichestvoFilmov"].HeaderText = "Количество фильмов";
                buildGridView.Columns["Birthday"].HeaderText = "Дата рождения";
                buildGridView.Columns["PhoneNumber"].HeaderText = "Номер телефона";
                buildGridView.Columns["Post"].HeaderText = "Должность";

                buildGridView.Columns.Remove("FilmBuilders");
            }

        }

        private void buildGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = buildGridView.HitTest(e.X, e.Y).RowIndex;
                if (stateRole != "Client")
                {
                    m.MenuItems.Add(new MenuItem("Добавить создателя", AddNewBuilder));

                    if (currentMouseOverRow >= 0)
                    {
                        using (Context db = new Context(connectionString))
                            buildId = (int)buildGridView.Rows[currentMouseOverRow].Cells["ID_Builder"].Value;

                        m.MenuItems.Add(new MenuItem("Изменить", UpdateBuilder));
                        m.MenuItems.Add(new MenuItem("Удалить", DeleteBuilder));
                    }
                }

                m.Show(buildGridView, new Point(e.X, e.Y));
            }
        }

        public void AddNewBuilder(object sender, EventArgs e)
        {
            new AddNewBuilder(connectionString, this).ShowDialog();
        }
        public void UpdateBuilder(object sender, EventArgs e)
        {
            new UpdateBuilders(connectionString, buildId, this).ShowDialog();
        }
        public void DeleteBuilder(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Context db = new Context(connectionString))
                {
                    db.Builders.Remove(db.Builders.Find(buildId));
                    db.SaveChanges();
                }
            }
            else
            {
                return;
            }

            showBuilders();
        }

        // конец Создателей

        // начало Подписка
        public void showPodpiska()
        {
            using (Context db = new Context(connectionString))
            {
                podGridView.DataSource = db.Database.SqlQuery<Podpiska>("SELECT * FROM Podpiska").ToList();

                podGridView.Columns["ID_Podpiska"].Visible = false;
                podGridView.Columns["NamePodpiska"].HeaderText = "Название";
                podGridView.Columns["Price"].HeaderText = "Стоимость";

                podGridView.Columns.Remove("UserPodpiskas");
            }
        }
        private void podBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = true;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = false;
            MainGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = false;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            showPodpiska();
        }

        private void podGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = podGridView.HitTest(e.X, e.Y).RowIndex;
                if (stateRole != "Client")
                {
                    m.MenuItems.Add(new MenuItem("Добавить подписку", AddNewPodpiska));

                    if (currentMouseOverRow >= 0)
                    {
                        using (Context db = new Context(connectionString))
                            podId = (int)podGridView.Rows[currentMouseOverRow].Cells["ID_Podpiska"].Value;

                        m.MenuItems.Add(new MenuItem("Изменить", UpdatePodpiska));
                        m.MenuItems.Add(new MenuItem("Удалить", DeletePodpiska));
                    }
                }

                m.Show(podGridView, new Point(e.X, e.Y));
            }
        }

        public void AddNewPodpiska(object sender, EventArgs e)
        {
            new AddNewPodpiska(connectionString, this).ShowDialog();
        }
        public void UpdatePodpiska(object sender, EventArgs e)
        {
            new UpdatePodpiska(connectionString, podId, this).ShowDialog();
        }
        public void DeletePodpiska(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Context db = new Context(connectionString))
                {
                    db.Podpiskas.Remove(db.Podpiskas.Find(podId));
                    db.SaveChanges();
                }
            }
            else
            {
                return;
            }

            showPodpiska();
        }

        // конец Подписка

        // начало Пользователи
        private void userBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = false;
            MainGridView.Visible = false;
            usersGridView.Visible = true;
            dataGridGlView.Visible = false;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            showUsers();
        }

        public void showUsers()
        {
            using (Context db = new Context(connectionString))
            {
                usersGridView.DataSource = db.Database.SqlQuery<User>("SELECT * FROM Users").ToList();

                usersGridView.Columns["ID_Usera"].Visible = false;
                usersGridView.Columns["Surname"].HeaderText = "Фамилия";
                usersGridView.Columns["FirstName"].HeaderText = "Имя";
                usersGridView.Columns["MiddleName"].HeaderText = "Отчество";
                usersGridView.Columns["UserLogin"].HeaderText = "Логин";
                usersGridView.Columns["UserPassword"].HeaderText = "Пароль";
                usersGridView.Columns["Birthday"].HeaderText = "Дата рождения";
                usersGridView.Columns["Email"].HeaderText = "Email";

                usersGridView.Columns.Remove("UserPodpiskas");
                usersGridView.Columns.Remove("ViewsFilmsUsers");
            }
        }

        private void usersGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = usersGridView.HitTest(e.X, e.Y).RowIndex;
                if (stateRole != "Client")
                {
                    m.MenuItems.Add(new MenuItem("Добавить пользователя", AddNewUser));

                    if (currentMouseOverRow >= 0)
                    {
                        using (Context db = new Context(connectionString))
                            userId = (int)usersGridView.Rows[currentMouseOverRow].Cells["ID_Usera"].Value;

                        m.MenuItems.Add(new MenuItem("Изменить", UpdateUser));
                        m.MenuItems.Add(new MenuItem("Удалить", DeleteUser));
                    }
                }

                m.Show(usersGridView, new Point(e.X, e.Y));
            }
        }

        public void AddNewUser(object sender, EventArgs e)
        {
            new AddNewUser(connectionString, this).ShowDialog();
        }
        public void UpdateUser(object sender, EventArgs e)
        {
            new UpdateUser(connectionString, userId, this).ShowDialog();
        }
        public void DeleteUser(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Context db = new Context(connectionString))
                {
                    db.Users.Remove(db.Users.Find(userId));
                    db.SaveChanges();
                }
            }
            else
            {
                return;
            }

            showUsers();
        }

        // конец Пользователей

        // начало Просмотров

        private void viewsBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = true;
            delusersGridView.Visible = false;
            MainGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = false;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            //showViews();
        }

        public void showViews()
        {
            using (Context db = new Context(connectionString))
            {
                viewGridView.DataSource = db.Database.SqlQuery<ViewsFilmsUser>("SELECT * FROM ViewsFilmsUser").ToList();

                viewGridView.Columns["ID_Views"].Visible = false;

                viewGridView.Columns["ID_Filma"].HeaderText = "Код фильма";
                viewGridView.Columns["ID_Usera"].HeaderText = "Код пользователя";
                viewGridView.Columns["DataProsmotra"].HeaderText = "Дата просмотра";


            }
        }

        private void viewGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = viewGridView.HitTest(e.X, e.Y).RowIndex;
                if (stateRole != "Client")
                {
                    m.MenuItems.Add(new MenuItem("Добавить просмотр", AddNewViews));

                    if (currentMouseOverRow >= 0)
                    {
                        using (Context db = new Context(connectionString))
                            viewId = (int)viewGridView.Rows[currentMouseOverRow].Cells["ID_Views"].Value;

                        m.MenuItems.Add(new MenuItem("Изменить", UpdateViews));
                        m.MenuItems.Add(new MenuItem("Удалить", DeleteViews));
                    }
                }

                m.Show(viewGridView, new Point(e.X, e.Y));
            }

        }

        public void AddNewViews(object sender, EventArgs e)
        {
            new AddNewView(connectionString, this).ShowDialog();
        }
        public void UpdateViews(object sender, EventArgs e)
        {
            new UpdateView(connectionString, userId, this).ShowDialog();
        }
        public void DeleteViews(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Context db = new Context(connectionString))
                {
                    db.Users.Remove(db.Users.Find(userId));
                    db.SaveChanges();
                }
            }
            else
            {
                return;
            }

            showUsers();
        }

        // конец Просмотров

        // начало удалённых пользователей

        public void showdelUser()
        {
            using (Context db = new Context(connectionString))
            {

                delusersGridView.DataSource = db.Database.SqlQuery<DeleteUser>("SELECT * FROM DeleteUsers").ToList();

                delusersGridView.Columns["ID_DELETED"].Visible = false;

                delusersGridView.Columns["Users_Surname"].HeaderText = "Фамилия";
                delusersGridView.Columns["Users_Name"].HeaderText = "Имя";
                delusersGridView.Columns["Users_Login"].HeaderText = "Логин";
                delusersGridView.Columns["Date_Deleted"].HeaderText = "Дата удаления";


            }
        }

        private void deluserBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = true;
            MainGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = false;

            searchinfotext.Visible = false;
            searchButton.Visible = false;
            keytext.Visible = false;
            keywordText.Visible = false;

            showdelUser();
        }




        // конец удалённых пользователей

        private void serachGlBut_Click(object sender, EventArgs e)
        {
            zhanrGridView.Visible = false;
            zhanrFGridView.Visible = false;
            actGridView.Visible = false;
            actFGridView.Visible = false;
            podGridView.Visible = false;
            poduserGridView.Visible = false;
            buildGridView.Visible = false;
            buildFGridView.Visible = false;
            viewGridView.Visible = false;
            delusersGridView.Visible = false;
            MainGridView.Visible = false;
            usersGridView.Visible = false;
            dataGridGlView.Visible = true;

            searchinfotext.Visible = true;
            searchButton.Visible = true;
            keytext.Visible = true;
            keywordText.Visible = true;

            showSerchData();
        }

        public void showSerchData()
        {
            using (Context db = new Context(connectionString))
            {

                da = new SqlDataAdapter("SELECT * FROM AllInfoFilms", connectionString);
                ds = new DataSet();
                da.Fill(ds, "dbo.AllInfoFilms");
                dataGridGlView.DataSource = ds.Tables["dbo.AllInfoFilms"];

            }
        }

        private DataTable searchResults; // новый экземпляр DataTable для хранения найденных данных
        private int lastFoundIndex = -1; // переменная для хранения индекса последней найденной строки
        private void searchButton_Click(object sender, EventArgs e)
        {

            string keyword = keywordText.Text;
            if (!string.IsNullOrEmpty(keyword))
            {
                // Очищаем список выделенных строк
                dataGridGlView.ClearSelection();

                    // Создаем новый экземпляр DataTable
                searchResults = new DataTable();
                searchResults.Columns.AddRange(dataGridGlView.Columns.Cast<DataGridViewColumn>().Select(c => new DataColumn(c.Name, c.ValueType)).ToArray());

                // Ищем совпадения начиная с последней найденной строки + 1
                for (int i = lastFoundIndex + 1; i < dataGridGlView.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridGlView.Rows[i];
                    bool containsKeyword = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(keyword))
                        {
                            containsKeyword = true;
                            break;
                        }
                    }

                    // Если найдено совпадение, добавляем строку в новый DataTable
                    if (containsKeyword)
                    {
                        searchResults.Rows.Add(row.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray());
                        lastFoundIndex = i; // сохраняем индекс последней найденной строки
                    }
                }

                // Если найдены строки, присваиваем новый источник данных для DataGridView
                if (searchResults.Rows.Count > 0)
                {
                    dataGridGlView.DataSource = searchResults;
                }
                else
                {
                    // Если ничего не найдено, выводим сообщение
                    MessageBox.Show("Ничего не найдено, проверьте введённые данные!\nЕсли ошибка не пропадает, то снова нажмите на кнопку 'Общая Таблица' и выполните поиск", "Информация", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                // Если ключевое слово пусто, выводим сообщение
                MessageBox.Show("Введите ключевое слово", "Информация", MessageBoxButtons.OK);
                return;
            }

        }

        private void hranimBut_Click(object sender, EventArgs e)
        {
            new CheckUserPodpiska(connectionString, this).ShowDialog();
        }

        private void scalBut_Click(object sender, EventArgs e)
        {
            new KolvoUserBuyPodpiska(connectionString, this).ShowDialog();
        }

        private void predBut_Click(object sender, EventArgs e)
        {
            new UsersViewsPred(connectionString, this).ShowDialog();
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
            new UpdatePricePodpiska(connectionString, this).ShowDialog();
        }
    }
}
